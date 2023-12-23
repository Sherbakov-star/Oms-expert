using System.Collections.Generic;
using System.IO;
using Lib.Helpers;

namespace Mee
{
    public class CodeDefectService
    {
        public List<T> GetDicFromJson<T>(string path)
        {
            var jsonText = File.ReadAllText(Path.Combine($"{System.Environment.GetEnvironmentVariable("USERPROFILE")}\\OmsFiles", path));

            var result = JsonHelper.Deserialize<List<T>>(jsonText);

            return result;
        }
    }
}
