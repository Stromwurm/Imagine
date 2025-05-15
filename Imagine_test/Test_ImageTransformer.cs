namespace Imagine_test;

using System.Drawing;

using Imagine;
using Imagine.Transformers;

[TestClass]
public sealed class Test_ImageTransformer
{
    [TestMethod]
    public void Test()
    {
        BinaryThresholdTransformer imgT = new();

        string file = @"C:\Users\erd67\Pictures\Screenshots\Screenshot 2025-03-11 214137.png";

        var bytes = File.ReadAllBytes(file);

        var bytes2 = imgT.Transform(bytes);

        var newName = @"C:\Users\erd67\Pictures\test\Screenshot 2025-03-11 214137_thresh.bmp";

        File.WriteAllBytes(newName, bytes2.Span.ToArray());

    }

    [TestMethod]
    public void Test2()
    {
        const string path = @"C:\Users\erd67\Documents\test\Spindle_001\Frames_EM 13_007_2024_10_01_15_15_33_ID_001_UUID_1_GOOD.tiff";

        FileInfo f = new FileInfo(path);

        var bytes = File.ReadAllBytes(path);

        var m = ImagineContext.DecodeAsMat(bytes);

    }

}
