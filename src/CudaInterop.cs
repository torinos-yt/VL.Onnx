using System;
using System.Runtime.InteropServices;

namespace Onnx
{

public static class CudaInterop
{
    [DefaultDllImportSearchPaths(DllImportSearchPath.AssemblyDirectory)]
    [DllImport("VL.Onnx.Native.dll")]
    public static extern IntPtr RegisterD3D11Resource(IntPtr buffer);

    [DefaultDllImportSearchPaths(DllImportSearchPath.AssemblyDirectory)]
    [DllImport("VL.Onnx.Native.dll")]
    public static extern IntPtr MapD3D11Resource(IntPtr resource);

    [DefaultDllImportSearchPaths(DllImportSearchPath.AssemblyDirectory)]
    [DllImport("VL.Onnx.Native.dll")]
    public static extern void UnMapD3D11Resource(IntPtr resource);

    [DefaultDllImportSearchPaths(DllImportSearchPath.AssemblyDirectory)]
    [DllImport("VL.Onnx.Native.dll")]
    public static extern void UnregisterD3D11Resource(IntPtr resource);
}

}