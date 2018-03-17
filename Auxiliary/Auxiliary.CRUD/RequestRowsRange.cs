namespace Auxiliary.CRUD
{
    public class RequestRowsRange
    {
        public long BeginRowNumber { get; }
        public long RowsCount { get; }

        public RequestRowsRange( long beginRowNumber, long rowsCount )
        {
            BeginRowNumber = beginRowNumber;
            RowsCount = rowsCount;
        }
    }
}
