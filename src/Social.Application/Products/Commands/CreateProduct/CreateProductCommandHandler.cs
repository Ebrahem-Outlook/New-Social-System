using Social.Application.Core.Abstractions.Authentication;
using Social.Application.Core.Abstractions.Data;
using Social.Application.Core.Abstractions.Emails;
using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Products;

namespace Social.Application.Products.Commands.CreateProduct;

internal sealed class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, string>
{
    private readonly IUserIdentifierProvider _userIdentifierProvider;
    private readonly IProductRepository _productRepository;
    private readonly IEmailService _emailService;
    private readonly IJwtProvider _jwtProvider;
    private readonly IUnitOfWork _unitOfWork;

    public CreateProductCommandHandler(IUserIdentifierProvider userIdentifierProvider, IProductRepository productRepository, IEmailService emailService, IJwtProvider jwtProvider, IUnitOfWork unitOfWork)
    {
        _userIdentifierProvider = userIdentifierProvider;
        _productRepository = productRepository;
        _emailService = emailService;
        _jwtProvider = jwtProvider;
        _unitOfWork = unitOfWork;
    }

    public Task<string> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
