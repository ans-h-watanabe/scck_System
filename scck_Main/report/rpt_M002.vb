Imports GrapeCity.ActiveReports
Imports GrapeCity.ActiveReports.Document
Imports utl_Com.utl_Com
'�@�\�T�v*****************************************************************************************************
'*
'*  �����T�v�F�Ɩ�����Ͻ�ؽ�
'*
'*  �쐬���@�F2018/02/01
'*  �쐬�ҁ@�F�n��      1.��V�X�e���X��
'*
'*  �X�V���@�F
'*  �X�V�ҁ@�F
'*  �X�V���e�F
'*
#Region " ������ "

'*
'*  �쐬���@�F2005/09/13
'*  �쐬�ҁ@�FAns��������
'*
'*  �X�V���@�F2006/04/19
'*  �X�V�ҁ@�FANS�a��c�q
'*  �X�V���e�FϽ�ؽđS�̒���
'*
'*  �X�V���@�F2008/08/08
'*  �X�V�ҁ@�F�R�c
'*  �X�V���e�F���ƕ��R�[�h�ˋƖ����ދ敪�ɕύX

#End Region
'*
'*************************************************************************************************************
Public Class rpt_M002

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        '
        Try
            If FID_�Ɩ����ދ敪.Text.Equals("00") Then
                FID_�Ɩ����ދ敪.Text = ""
            End If
            If FID_�o�^���[�U�[ID.Text.Equals("0000000") Then
                FID_�o�^���[�U�[ID.Text = ""
            End If
            If FID_�X�V���[�U�[ID.Text.Equals("0000000") Then
                FID_�X�V���[�U�[ID.Text = ""
            End If
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_SUB:
        Exit Sub
    End Sub

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        '
        Try
            LBL_�������.Text = Format(Now(), "yy/MM/dd HH:mm:ss")
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_SUB:
        Exit Sub
    End Sub

    Private Sub PageFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.Format
        '
        Try
            '
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_SUB:
        Exit Sub
    End Sub

End Class
