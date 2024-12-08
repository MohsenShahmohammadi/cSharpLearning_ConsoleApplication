using Common;
using Domain.Gnr;

namespace Services.Gnr;

public class StudentService
{
    public int Add(Student student)
    {
        var result = true;
        /****** work ***/
        if (result)
        {

            return (int)ResultCode.ResultStatusCode.Success;
        }
        else
        {
            return (int)ResultCode.ResultStatusCode.InternalError; ;
        }
        
    }
}
