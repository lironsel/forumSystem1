using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumSystem.model
{
    class Forum
    {
        Policy contains1;
        ErrorLogger reports1;
        ActionLogger reports2;
        List<loginWindow> login_user;
        List<SubForum> contains;
        List<Admin> managed;
        List<User> member;
        List<Group> contains2;

        public void newDiscussion(String forumID, String subForumID, String subject,User user) { }
        public void searchForum(String forumID) { }
        public void searchSubForum(String subForumID) { }
        public void getModertors(String forumID, String subForumID) { }
        //public void searchSubForum(String subForumID) { }
        public void deleteModerator(String forumID, String subForumID, String moderatorID) { }
        public void createOpeningMessage(String forumID, String subforumID, String threadID, String message, user) { }
        public void createMessage(String message) { }
        public void ButtonGoToConnectWindow() { }
        public void create_LW() { }
        public void loginGuest() { }
    }
}
