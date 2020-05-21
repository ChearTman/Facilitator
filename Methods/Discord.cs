using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Facilitator.Discord
{

    public class Discord
    {
        class Http
        {
            public static byte[] Post(string url, NameValueCollection pairs)
            {
                using (WebClient webClient = new WebClient())
                    return webClient.UploadValues(url, pairs);
            }
        }

        public void send(string content, string webHookUrl)
        {
            Http.Post(webHookUrl, new NameValueCollection()
        {
            {
                "content", content
            },

        });

        }
        public void send(string content, string webHookUrl, string username)
        {

            Http.Post(webHookUrl, new NameValueCollection()
        {
            {
                "content", content
            },
            {
                "username", username
            }
        });
        }
        public void send(string content, string webHookUrl, string username, string avatarUrl)
        {
            Http.Post(webHookUrl, new NameValueCollection()
        {
            {
                "content", content
            },
            {
                "username", username
            },
            {
                "avatarURL", avatarUrl
            }
        });
        }
    }
}

