#define EXPORT_API extern "C" __declspec(dllexport)

#include "cuda_runtime.h"
#include "cuda_d3d11_interop.h"

#define CHECK(X) if(X != cudaSuccess) { return nullptr; }

EXPORT_API void* RegisterD3D11Resource(void* buffer)
{
    if (buffer == nullptr) return nullptr;

    cudaGraphicsResource_t* resource = new cudaGraphicsResource_t();
    CHECK(cudaGraphicsD3D11RegisterResource(resource,
        (ID3D11Resource*)buffer, cudaGraphicsRegisterFlagsNone));

	return resource;
}

EXPORT_API void* MapD3D11Resource(cudaGraphicsResource_t* resource)
{
    if (resource == nullptr) return nullptr;
 
    CHECK(cudaGraphicsMapResources(1, resource));

    size_t size;
    void* ptr;
    CHECK(cudaGraphicsResourceGetMappedPointer(&ptr, &size, *resource));

    return ptr;
}

EXPORT_API void UnMapD3D11Resource(cudaGraphicsResource_t* resource)
{
    if (resource == nullptr) return;

    cudaGraphicsUnmapResources(1, resource);
}

EXPORT_API void UnRegisterD3D11Resource(cudaGraphicsResource_t* resource)
{
    if (resource == nullptr) return;

    cudaGraphicsUnregisterResource(*resource);
}
