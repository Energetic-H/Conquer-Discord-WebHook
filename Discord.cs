using System.Collections.Specialized;
using System;
using System.Net.Http;
using System.Net;

namespace COServer
{
    class Discord
    {
        public static void DiscordSendMessage(string username, string content, string face)
        {
            if (content.Contains("@everyone") || content.Contains("@"))
            {
                return;
            }
            WebClient wc = new WebClient();
            try
            {
                wc.UploadValues("Your Web Hook URL", new NameValueCollection
            {
                {
                    "username",username
                },
                
                {
                    "content",content
                },
              
                {
                    "avatar_url",face
                }
            });
               
            }
            catch (WebException ex)
            {
               
            }
        
        }
    }
}
        
 


