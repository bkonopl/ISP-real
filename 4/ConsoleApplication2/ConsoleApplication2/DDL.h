#pragma once

#ifdef DDLDLL_EXPORTS
#define DLLIMPORT_EXPORT __declspec(dllexport)
#else
#define DLLIMPORT_EXPORT __declspec(dllimport)
#endif

extern "C" {
    DLLIMPORT_EXPORT int _stdcall Multiply(int a, int b);
    DLLIMPORT_EXPORT int _stdcall Divide(int a, int b);
    DLLIMPORT_EXPORT int _cdecl Pow(int a, int power);
}
