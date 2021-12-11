#include "pch.h"
#include "Class.h"
#include "Class.g.cpp"

namespace winrt::WinRTComponent::implementation
{
	hstring componentString = L"Hello from an Non-Packaged WinRT Component! :D";

	hstring Class::MyFunction() {
		return componentString;
	}
}
