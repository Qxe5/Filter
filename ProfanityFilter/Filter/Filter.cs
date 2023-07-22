namespace Panopticon
{
    public class Filter
    {
        private readonly string[] FilterList;

        public Filter(string[] filterList)
        {
            FilterList = filterList;
        }

        public string Censor(string message)
        {
            var filter = new ProfanityFilter.ProfanityFilter(FilterList);
            return filter.CensorString(message);
        }
    }
}
