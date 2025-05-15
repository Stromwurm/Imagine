namespace Imagine.Converters;

using System.Drawing;

using OpenCvSharp;
using OpenCvSharp.Extensions;

public class MatBitmapConverter : IImageConverter<Bitmap, Mat>
{
    public Mat Convert(Bitmap data)
    {
        var m = BitmapConverter.ToMat(data);
        return m;
    }

    public Bitmap Convert(Mat data)
    {
        var m = BitmapConverter.ToBitmap(data);
        return m;
    }
}
