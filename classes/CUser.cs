using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Newtonsoft.Json;

namespace JIRA.classes
{
    public class CUserRootObject
    {
        public string expand { get; set; }
        public List<CJiraProject> projects { get; set; }
    }

    public class CUser
    {
        private CUserRootObject root;

        public string UserName { get; private set; }
        public bool LoggedIn { get; set; }

        public List<CJiraProject> Projects
        {
            get
            {
                if (root != null)
                    return root.projects;
                else
                    return null;
            }
        }


        public CUser(string username, Stream httpLoginResponse)
        {
            UserName = username;

            Parse(httpLoginResponse);
        }

        private void Parse(Stream httpLoginResponse)
        {
            // check if logged in

            // get JSON strintg
            string json = new StreamReader(httpLoginResponse).ReadToEnd();

            root = JsonConvert.DeserializeObject<CUserRootObject>(json);

            LoggedIn = true;
        }
    }
}
