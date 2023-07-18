# VL.Onnx

## Install
Requires CUDA 11.x and corresponding cudnn.
(and optionally, [TensorRT](https://onnxruntime.ai/docs/execution-providers/TensorRT-ExecutionProvider.html))

see here : https://onnxruntime.ai/docs/execution-providers/CUDA-ExecutionProvider.html

The easiest way to get these is to install the latest [Azure Kinect Body Tracking SDK](https://learn.microsoft.com/en-us/azure/kinect-dk/body-sdk-download).

## Note
Currently TensorRT Option settings through C#api do not work. You will need to configure the settings in environment variables if necessary.
  
https://onnxruntime.ai/docs/execution-providers/TensorRT-ExecutionProvider.html#environment-variables