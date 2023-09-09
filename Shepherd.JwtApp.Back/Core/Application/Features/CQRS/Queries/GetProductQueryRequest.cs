using MediatR;

namespace Shepherd.JwtApp.Back;
public class GetProductQueryRequest : IRequest<ProductListDto>
{
    public int Id { get; set; }

    public GetProductQueryRequest(int id)
    {
        Id = id;
    }
}
