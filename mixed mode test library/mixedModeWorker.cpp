#include "mixedModeWorker.h"
#include "MixedModeClass.cpp"

void __stdcall switchOffWeirdness()
{
    MixedModeClass::doSomethingWeired = false;
}

bool __stdcall initMixedModeDll()
{
    MixedModeClass::Initialize();

    return true;
}