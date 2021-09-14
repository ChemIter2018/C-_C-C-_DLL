#ifndef CCPLUSDLL_LIBRARY_H
#define CCPLUSDLL_LIBRARY_H

extern "C" void hello();

extern "C"  __declspec(dllexport) int Minus(int a, int b);
extern "C"  __declspec(dllexport) int Add(int a, int b);

#endif //CCPLUSDLL_LIBRARY_H
