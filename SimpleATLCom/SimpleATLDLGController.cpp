// SimpleATLDLGController.cpp : CSimpleATLDLGController ��ʵ��
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
	// TODO: �ڴ����ʵ�ִ���

	return S_OK;
}


STDMETHODIMP CSimpleATLDLGController::InvokeDialog3()
{
	// TODO: �ڴ����ʵ�ִ���
	CSimpleATLDialog atlDLg;
	atlDLg.DoModal();
	return S_OK;
}
