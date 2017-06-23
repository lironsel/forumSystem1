namespace forumSystem.model
{
    class Complaint
    {
        string refers_to;
        string submitted_by;
        string complaint;

        public Complaint (string complaint, string filedBy, string filedOn)
        {
            this.complaint = complaint;
            this.submitted_by = filedBy;
            this.refers_to = filedOn;
        }
    }
}
