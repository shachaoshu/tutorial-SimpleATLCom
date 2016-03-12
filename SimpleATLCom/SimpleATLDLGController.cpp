// SimpleATLDLGController.cpp : CSimpleATLDLGController 的实现
#include "stdafx.h"
#include "SimpleATLDLGController.h"
#include "SimpleATLDialog.h"
// CSimpleATLDLGController

STDMETHODIMP CSimpleATLDLGController::InvokeDialog(void)
{
	CSimpleATLDialog atlDLg;
	atlDLg.DoModal();
	return S_OK;
}


STDMETHODIMP CSimpleATLDLGController::InvokeDialog2()
{
	// TODO: 在此添加实现代码

	return S_OK;
}


STDMETHODIMP CSimpleATLDLGController::InvokeDialog3()
{
	// TODO: 在此添加实现代码
	CSimpleATLDialog atlDLg;
	atlDLg.DoModal();
	return S_OK;
}
