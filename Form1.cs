using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Net;
using System.Linq;
using System.Text;
using System.Web;
using System.ServiceModel.Channels;
using System.ServiceModel;
using System.Windows.Forms;

namespace Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < _lstLanguages.Items.Count; i++)
            {
                _lstLanguages.SetItemChecked(i, true);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string clientID = _txtClientID.Text;
            string clientSecret = _txtClientSecret.Text;

            if (string.IsNullOrEmpty(clientID + clientSecret))
            {
                throw new Exception("You need to enter the clientID and clientSecret values");
            }
            
            _txtResult.Text = string.Empty;
            AdmAccessToken admToken;
            string headerValue;
            //Get Client Id and Client Secret from https://datamarket.azure.com/developer/applications/
            //Refer obtaining AccessToken (http://msdn.microsoft.com/en-us/library/hh454950.aspx) 
            AdmAuthentication admAuth = new AdmAuthentication(clientID, clientSecret);
            try
            {
                admToken = admAuth.GetAccessToken();
                // Create a header with the access_token property of the returned token
                headerValue = "Bearer " + admToken.access_token;
            }
            catch (WebException ex)
            {
                _txtResult.Text += "Error: " + ex.Message;
                return;


            }
            catch (Exception ex)
            {
                _txtResult.Text += "Error: " + ex.Message;
                return;
            }


            string txtToTranslate = _txtEnglish.Text;
            Dictionary<string, string> translations = new Dictionary<string, string>();
            Dictionary<string, string> actuallanguageTranslations = new Dictionary<string, string>();
            actuallanguageTranslations.Add("en", _txtEnglish.Text);
            string template = "<data name=\"{0}\" xml:space=\"preserve\">\r\n\t<value>{1}</value>\r\n\t<comment>UNOFFICIAL_TRANSLATION</comment>\r\n</data>";
            StringBuilder result = new StringBuilder();
            foreach (string s in _lstLanguages.CheckedItems)
            {
                string languageCode = s.Substring(0,2);
                if (!actuallanguageTranslations.Keys.Contains(languageCode))
                {
                    string uri = "http://api.microsofttranslator.com/v2/Http.svc/Translate?text=" + System.Web.HttpUtility.UrlEncode(txtToTranslate) + "&from=en&to=" + languageCode;
                    System.Net.WebRequest translationWebRequest = System.Net.WebRequest.Create(uri);
                    translationWebRequest.Headers.Add("Authorization", headerValue);
                    System.Net.WebResponse response = null;
                    response = translationWebRequest.GetResponse();
                    System.IO.Stream stream = response.GetResponseStream();
                    System.Text.Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
                    System.IO.StreamReader translatedStream = new System.IO.StreamReader(stream, encode);
                    System.Xml.XmlDocument xTranslation = new System.Xml.XmlDocument();
                    xTranslation.LoadXml(translatedStream.ReadToEnd());
                    actuallanguageTranslations.Add(languageCode, xTranslation.InnerText);
                }
                string translation = string.Format(template, _txtResID.Text, actuallanguageTranslations[languageCode]);
                translations.Add(s, translation);
                result.Append(s + ":\r\n");
                result.Append(translation);
                result.Append("\r\n\r\n");
            }

            _txtResult.Text = result.ToString();


            if (!string.IsNullOrEmpty(_txtResPath.Text))
            {
                foreach (KeyValuePair<string, string> translation in translations)
                {
                    string fileName = Path.Combine(_txtResPath.Text, string.Format("strings.{0}.resx", translation.Key));
                    if (File.Exists(fileName))
                    {
                        List<string> lines = new List<string>(File.ReadAllLines(fileName));
                        int x;
                        for (x = lines.Count - 1; x > 0; x--)
                        {
                            if (lines[x].Trim().StartsWith("</root>"))
                            {
                                break;
                            }
                        }
                        lines.Insert(x, translation.Value);
                        File.WriteAllLines(fileName, lines.ToArray());
                    }
                }
            }
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://blogs.msdn.com/b/translation/p/gettingstarted1.aspx");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}