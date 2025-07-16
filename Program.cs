using System.Collections.Generic;
using Pulumi;
using Pulumi.Local;

return await Deployment.RunAsync(() =>
{
    var foo = GetFile.Invoke(new()
    {
        Filename = "./Pulumi.yaml",
    });


    // Export outputs here
    return new Dictionary<string, object?>
    {
        ["outputKey"] = "outputValue"
    };
});
