namespace Post.Cmd.Api.Commands;

using CQRS.Core.Commands;

public class NewPostCommand: BaseCommand
{
    public NewPostCommand(string raisedBy, string text) : base(raisedBy)
    {
        // assumed that author is same as the user who added the post (Raised the event)
        this.Author = raisedBy;
        this.Text = text;
    }

    public string Author { get; set; }
    public string Text { get; set; }
}
