using System;
using System.Reflection;

using SharpDXBuffer = SharpDX.Direct3D11.Buffer;
using StrideBuffer = Stride.Graphics.Buffer;

public static class NativeBufferExtractorExtensions
{
    public static IntPtr GetGraphicResourcePtr(this StrideBuffer strideBuffer)
    {
        if (strideBuffer == null) return IntPtr.Zero;

        Type info = strideBuffer.GetType();

        PropertyInfo property = info.GetProperty("NativeBuffer", BindingFlags.InvokeMethod | BindingFlags.NonPublic | BindingFlags.Instance);
        SharpDXBuffer sharpDxBuffer = (SharpDXBuffer)property.GetValue(strideBuffer);

        return sharpDxBuffer.NativePointer;
    }
}