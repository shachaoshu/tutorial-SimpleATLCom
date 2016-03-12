// SimpleCom.cpp : CSimpleCom 的实现

#include "stdafx.h"
#include "SimpleCom.h"


// CSimpleCom



STDMETHODIMP CSimpleCom::Calculate(VARIANT_BOOL a_bFireEvent, LONG* a_lTotalMarks)
{
	// TODO: 在此添加实现代码
	*a_lTotalMarks = m_lATLMarks + m_lComMarks;
	if (a_bFireEvent == VARIANT_TRUE)
		Fire_TotalMarks(*a_lTotalMarks);
	return S_OK;
}


STDMETHODIMP CSimpleCom::get_ComMarks(LONG* pVal)
{
	// TODO: 在此添加实现代码
	*pVal = m_lComMarks;
	return S_OK;
}


STDMETHODIMP CSimpleCom::put_ComMarks(LONG newVal)
{
	// TODO: 在此添加实现代码
	m_lComMarks = newVal;
	return S_OK;
}


STDMETHODIMP CSimpleCom::get_AtlMarks(LONG* pVal)
{
	// TODO: 在此添加实现代码
	*pVal = m_lATLMarks;
	return S_OK;
}


STDMETHODIMP CSimpleCom::put_AtlMarks(LONG newVal)
{
	// TODO: 在此添加实现代码
	m_lATLMarks = newVal;
	return S_OK;
}


STDMETHODIMP CSimpleCom::get_StudentName(BSTR* pVal)
{
	// TODO: 在此添加实现代码
	*pVal = m_bstStudName.Copy();
	return S_OK;
}


STDMETHODIMP CSimpleCom::put_StudentName(BSTR newVal)
{
	// TODO: 在此添加实现代码
	m_bstStudName = newVal;
	return S_OK;
}
