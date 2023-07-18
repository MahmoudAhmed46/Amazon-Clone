using Amazon.Application.Contracts;
using Amazon.Context;
using Amazon.Domain;
using Amazon.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Infrastrucure
{
    public class ImageReposatory : Reposatory<Image, int>, IImageReposatory
    {
        ApplicationContext Context;
        public ImageReposatory(ApplicationContext context) : base(context)
        {
            Context = context;
        }

        public  string GetImagesByCategoryId(int id)
        {
            var res = Context.Images.FirstOrDefault(p => p.categoryId == id)?.Name;
            return res;
        }

        public async Task<List<string>> GetImagesByPrdId(int id)
        {
            var res = Context.Images.Where(p => p.ProductID == id).Select(i=>i.Name).ToList();
            return res;
        }
    }
}
