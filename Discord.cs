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
                wc.UploadValues("https://discord.com/api/webhooks/994871482188578858/6qBi5ldbSsRXB5HWf2jJV_jfVKYKZ657YQ7k626mBlpDPCmLi_iSDD2xVbxPl4KOhVAB", new NameValueCollection
            {
                {
                    "content",content
                },
                {
                    "username",username
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
        
 


