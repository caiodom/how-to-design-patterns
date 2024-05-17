using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Utils
{
    public static class Translators
    {
        public static string StatusTranslater(Status status)
        {
            switch (status)
            {
                case Status.PENDING:
                    return "Pending";
                case Status.IN_PROGRESS:
                    return "In Progress";
                case Status.COMPLETED:
                    return "Completed";
                default:
                    return "Not found";
            }
        }

        public static string PriorityTranslater(Priority priority)
        {
            switch (priority)
            {
                case Priority.HIGH:
                    return "High";
                case Priority.MEDIUM:
                    return "Medium";
                case Priority.LOW:
                    return "Low";
                default:
                    return "Not Found";
            }
        }
    }
}
