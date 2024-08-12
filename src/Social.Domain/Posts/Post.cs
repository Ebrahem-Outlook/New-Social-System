using Social.Domain.Core.BaseType;
using Social.Domain.Posts.Entities;
using Social.Domain.Posts.Events;

namespace Social.Domain.Posts;

public sealed class Post : AggregateRoot
{
    private Post(Guid userId, string title, string context)
        : base(Guid.NewGuid())
    {
        UserId = userId;
        Title = title;
        Context = context;
        Comments = [];
        Likes = [];
        Shares = [];
        CreatedOnUtc = DateTime.UtcNow;
    }

    private Post() : base() { }

    public Guid UserId { get; }
    public string Title { get; private set; } = default!;
    public string Context { get; private set; } = default!;
    public List<Comment> Comments { get; private set; } = [];
    public List<Like> Likes { get; private set; } = [];
    public List<Share> Shares { get; private set; } = [];
    public DateTime CreatedOnUtc { get; }
    public DateTime? UpdatedOnUtc { get; private set; }

    public static Post Create(Guid userId, string title, string context)
    {
        Post post = new Post(userId, title, context);

        post.RaiseDomainEvent(new PostCreatedDomainEvent(post));

        return post;
    }

    public void Update(string title, string context)
    {
        Title = title;
        Context = context;
        UpdatedOnUtc = DateTime.UtcNow;

        RaiseDomainEvent(new PostUpdatedDomainEvent(this));
    }

    public void NewLike(Like like)
    {
        Likes.Add(like);

        RaiseDomainEvent(new NewLikeDomainEvent(like));
    }

    public void NewComment(Comment comment)
    {
        Comments.Add(comment);

        RaiseDomainEvent(new NewCommentDomainEvent(comment));
    }

    public void NewShare(Share share)
    {
        Shares.Add(share);

        RaiseDomainEvent(new NewShareDomainEvent(share));
    }
}
