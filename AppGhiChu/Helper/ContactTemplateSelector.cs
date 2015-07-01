using AppGhiChu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AppGhiChu
{
    public class ContactTemplateSelector : TemplateSelector
    {
        public DataTemplate QuaHan
        {
            get;
            set;
        }

        public DataTemplate ChuaQuaHan
        {
            get;
            set;
        }


        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var contact = item as GhiChu;
            if (contact.Time < DateTime.Now.AddMinutes(-1))
            {
                return QuaHan;
            }

            return ChuaQuaHan;
        }
    }
}
