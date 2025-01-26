using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestBankManager_Project
{

    internal class User
    {
        public static String userName = null;
        public static String passWord;
        public static bool allowCreateQuestBank;
        public static bool allowDeleteQuestBank;
        public static bool allowModifyQuestBank;
        public static bool allowAccessQuestBank;
        public User(String userNameInp, String passWordInp)
        {
            userName = userNameInp;
            passWord = passWordInp;
        }
        public String getUserName()
        {
            return userName;
        }
        public void setUserName(String name)
        {
            userName=name;
        }
    }

}
