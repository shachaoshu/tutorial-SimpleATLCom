// SimpleATLDialog.cpp : CSimpleATLDialog µÄÊµÏÖ

#include "stdafx.h"
#include "SimpleATLDialog.h"
#include "SimpleCom.h"


// CSimpleATLDialog


LRESULT CSimpleATLDialog::OnBnClickedButton1(WORD /*wNotifyCode*/, WORD /*wID*/, HWND /*hWndCtl*/, BOOL& /*bHandled*/)
{
	int lATLMarks = this->GetDlgItemInt(IDC_EDIT_ATLMARKS);
	int lCOMMarks = this->GetDlgItemInt(IDC_EDIT_COMMARKS);
	TCHAR strName[100];
	GetDlgItemText(IDC_EDIT_NAME, strName, 250);
	CComObject<CSimpleCom>* simpleComObj;
	HRESULT hRes = CComObject<CSimpleCom>::CreateInstance(&simpleComObj);

	if (SUCCEEDED(hRes))
	{
		long totalMarks = 0;
		simpleComObj->put_AtlMarks(lATLMarks);
		simpleComObj->put_ComMarks(lCOMMarks);
		simpleComObj->Calculate(VARIANT_FALSE, &totalMarks);

		TCHAR strMsg[150];
		wsprintf(strMsg, _T("%s got following Marks %d"), strName, totalMarks);

		MessageBox(strMsg);

	}
	else
	{
		MessageBox(_T("Initialization Failed"));
	}

	return 0;
}
