namespace Imagine.Transformers;

using OpenCvSharp;

public class BinaryThresholdTransformer : IImageTransformerMem
{
    private const double ThresholdMinValue = 0;
    private const double ThresholdMaxValue = 255;

    private double _threshold = 127.5;
    public double Threshold => _threshold;

    private const ThresholdTypes ThresholdType = ThresholdTypes.Binary;

    public BinaryThresholdTransformer(double threshold = 127.5)
    {
        _threshold = threshold;
    }

    public void SetThreshold(double threshold)
    {
        _threshold = threshold;
    }

    public Memory<byte> Transform(Memory<byte> data)
    {
        var m = data.DecodeAsMat();
        var m2 = m.Threshold(_threshold, ThresholdMaxValue, ThresholdType);

        return m2.EncodeAsMem();
    }

    public Memory<byte>[] Transform(Memory<byte>[] data)
    {
        var m = data.DecodeAsMat();

        for (int i = 0; i < m.Length; i++)
        {
            m[i] = m[i].Threshold(_threshold, ThresholdMaxValue, ThresholdType);
        }

        return m.EncodeAsMem();
    }
}

public class MinImageTransformer : IImageTransformer<Mat, Mat>
{
    public Mat[] TransformMultipleImages(Mat[] data)
    {
        return data;
    }

    public Mat TransformSingleImage(Mat data)
    {
        throw new NotImplementedException();
    }
}

