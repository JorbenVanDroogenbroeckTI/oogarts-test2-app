namespace Oogarts.Shared.EyeConditions;

public abstract class EyeConditionRequest
{
	public class Index
	{
		public string? Searchterm { get; set; }
		public int Page { get; set; } = 1;
		public int PageSize { get; set; } = 25;
        public long? SymptomId { get; set; }

    }
}	