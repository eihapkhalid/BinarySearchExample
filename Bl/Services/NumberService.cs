using Bl.Interfaces;
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Services
{
    public class NumberService : IBusinessLayer<TbNumber>
    {
        int IBusinessLayer<TbNumber>.BinarySearch(int[] arr, int target)
        {

            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == target)
                {
                    return mid; // تم العثور على التطابق، يتم إرجاع المؤشر (الفهرس) للعنصر
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1; // العنصر المطلوب أكبر من العنصر الموجود في النصف الأوسط، لذا نتحقق من الجزء الأيمن من المصفوفة
                }
                else
                {
                    right = mid - 1; // العنصر المطلوب أصغر من العنصر الموجود في النصف الأوسط، لذا نتحقق من الجزء الأيسر من المصفوفة
                }
            }

            return -1; // لم يتم العثور على التطابق، يتم إرجاع قيمة -1
        }
    }
}
