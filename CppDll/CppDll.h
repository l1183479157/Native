#include <Windows.h>
#pragma once
extern "C" __declspec(dllexport) LPWSTR __stdcall CreateString();
extern "C" __declspec(dllexport) void __stdcall WriteString(LPWSTR lpwstr);
extern "C" __declspec(dllexport) void __stdcall FreeString(LPWSTR lpwstr);
