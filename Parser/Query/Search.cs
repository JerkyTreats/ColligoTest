using System.Collections.Generic;

namespace Colligo.REST.Query
{
	/// <summary>
	/// Forms the Search API call with the appropriate query parameters
	/// </summary>
	public class Search : IQuery
	{
		public BasicQueryParameter KeyWords = new BasicQueryParameter("keywords");
		public BasicQueryParameter Language = new BasicQueryParameter("language");
		public BasicQueryParameter Location = new BasicQueryParameter("location");
		public BasicQueryParameter Within = new BasicQueryParameter("within");
		public BasicQueryParameter Date = new BasicQueryParameter("date");
		public Units Units = new Units();
		public Category Category = new Category();
		public ExCategory ExCategory = new ExCategory();
		public CountOnly CountOnly = new CountOnly();
		public PageSize PageSize = new PageSize();
		public PageNumber PageNumber = new PageNumber();
		public ChangeMultiDayStart ChangeMultiDayStart = new ChangeMultiDayStart();
		public SortOrder SortOrder = new SortOrder();
		public SortDirection SortDirection = new SortDirection();
		public Mature Mature = new Mature();
		public Include Include = new Include();
		public Image Image = new Image();

		List<IQueryParameter> QueryParameters = new List<IQueryParameter>();

		//Tells us the Type the JSON deserializer should populate
		public System.Type Response = typeof(Response.Search);

		public Search()
		{
			QueryParameters.Add(KeyWords);
			QueryParameters.Add(Location);
			QueryParameters.Add(Within);
			QueryParameters.Add(Units);
			QueryParameters.Add(Date);
			QueryParameters.Add(Category);
			QueryParameters.Add(ExCategory);
			QueryParameters.Add(CountOnly);
			QueryParameters.Add(PageSize);
			QueryParameters.Add(PageNumber);
			QueryParameters.Add(Language);
			QueryParameters.Add(ChangeMultiDayStart);
			QueryParameters.Add(SortOrder);
			QueryParameters.Add(SortDirection);
			QueryParameters.Add(Mature);
			QueryParameters.Add(Include);
			QueryParameters.Add(Image);
		}

		public string GetQuery()
		{
			return QueryTools.GetQuery(QueryParameters);
		}

		static Parser.QueryTypes Type = Parser.QueryTypes.Search;
		public Parser.QueryTypes GetQueryType()
		{
			return Type;
		}
	}
}
