using Social.Application.Core.Abstractions.Authentication;
using Social.Application.Core.Abstractions.Data;
using Social.Application.Core.Abstractions.Emails;
using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Products;

namespace Social.Application.Posts.Commands.CreatePost;

internal sealed class CreatePostCommandHandler : ICommandHandler<CreatePostCommand, string>
{
    private readonly IProductRepository _productRepository;
    private readonly IEmailService _emailService;
    private readonly IJwtProvider _jwtProvider;
    private readonly IUnitOfWork _unitOfWork;

    public CreatePostCommandHandler(IProductRepository productRepository, IEmailService emailService, IJwtProvider jwtProvider, IUnitOfWork unitOfWork)
    {
        _productRepository = productRepository;
        _emailService = emailService;
        _jwtProvider = jwtProvider;
        _unitOfWork = unitOfWork;
    }

    public Task<string> Handle(CreatePostCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
