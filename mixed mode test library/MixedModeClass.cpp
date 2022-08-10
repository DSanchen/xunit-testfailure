#pragma once

using namespace System;

public ref class MixedModeClass
{
public:

	static bool doSomethingWeired;

	static MixedModeClass()
	{
		doSomethingWeired = true;
	}

	static void Initialize()
	{
		if (doSomethingWeired)
		{
			throw gcnew Exception("doh");
		}
	}
};