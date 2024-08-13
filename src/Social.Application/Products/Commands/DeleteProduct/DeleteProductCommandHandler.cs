using Social.Application.Core.Abstractions.Messaging;

namespace Social.Application.Products.Commands.DeleteProduct;

internal sealed class DeleteProductCommandHandler : ICommandHandler<DeleteProductCommand, string>
{
    public Task<string> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
