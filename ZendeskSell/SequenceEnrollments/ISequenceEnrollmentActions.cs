using System.Threading.Tasks;
using ZendeskSell.Models;

namespace ZendeskSell.SequenceEnrollments {
    public interface ISequenceEnrollmentActions {
        Task<ZendeskSellCollectionResponse<SequenceEnrollmentResponse>> GetAsync(int pageNumber, int numPerPage, int[] ids = null, int[] resourceIDs = null, string resourceType = null);
        Task<ZendeskSellObjectResponse<SequenceEnrollmentResponse>> GetOneAsync(long id);
        Task<ZendeskSellObjectResponse<SequenceEnrollmentResponse>> CreateAsync(SequenceEnrollmentCreateRequest enrollment);
        Task<ZendeskSellObjectResponse<SequenceEnrollmentResponse>> UpdateAsync(long id, SequenceEnrollmentUpdateRequest enrollment);
        Task<ZendeskSellObjectResponse<SequenceEnrollmentFinishResponse>> FinishOngoingForResourceAsync(long id, SequenceEnrollmentFinishRequest finishRequest);
    }
}
