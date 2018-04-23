﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraRichEdit.API.Native

Namespace BulletedListExample
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			richEditControl1.CreateNewDocument()
		End Sub
		Private Sub btnSimpleBullet_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSimpleBullet.Click
			Dim doc As Document = richEditControl1.Document
			doc.BeginUpdate()
			'Describe the pattern used for bulleted list.
			'Specify parameters used to represent each list level, up to the eighth level.
'			#Region "#abstractbulletlist"
			Dim list As AbstractNumberingList = richEditControl1.Document.AbstractNumberingLists.Add()
			list.NumberingType = NumberingType.Bullet

			Dim level As ListLevel = list.Levels(0)
			level.ParagraphProperties.LeftIndent = 150
			level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging
			level.ParagraphProperties.FirstLineIndent = 75
			level.CharacterProperties.FontName = "Symbol"
			level.DisplayFormatString = New String(ChrW(&H00B7),1)


			level = list.Levels(1)
			level.ParagraphProperties.LeftIndent = 300
			level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging
			level.ParagraphProperties.FirstLineIndent = 75
			level.CharacterProperties.FontName = "Symbol"
			level.DisplayFormatString = New String(ChrW(&H006F), 1)
'			#End Region ' #abstractbulletlist

			level = list.Levels(2)
			level.ParagraphProperties.LeftIndent = 450
			level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging
			level.ParagraphProperties.FirstLineIndent = 75
			level.NumberingFormat = NumberingFormat.Bullet
			level.CharacterProperties.FontName = "Symbol"
			level.DisplayFormatString = New String(ChrW(&H00B7), 1)


			level = list.Levels(3)
			level.ParagraphProperties.LeftIndent = 600
			level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging
			level.ParagraphProperties.FirstLineIndent = 75
			level.NumberingFormat = NumberingFormat.Bullet
			level.CharacterProperties.FontName = "Symbol"
			level.DisplayFormatString = New String(ChrW(&H006F), 1)


			level = list.Levels(4)
			level.ParagraphProperties.LeftIndent = 750
			level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging
			level.ParagraphProperties.FirstLineIndent = 75
			level.NumberingFormat = NumberingFormat.Bullet
			level.CharacterProperties.FontName = "Symbol"
			level.DisplayFormatString = New String(ChrW(&H00B7), 1)


			level = list.Levels(5)
			level.ParagraphProperties.LeftIndent = 900
			level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging
			level.ParagraphProperties.FirstLineIndent = 75
			level.NumberingFormat = NumberingFormat.Bullet
			level.CharacterProperties.FontName = "Symbol"
			level.DisplayFormatString = New String(ChrW(&H006F), 1)


			level = list.Levels(6)
			level.ParagraphProperties.LeftIndent = 1050
			level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging
			level.ParagraphProperties.FirstLineIndent = 75
			level.NumberingFormat = NumberingFormat.Bullet
			level.CharacterProperties.FontName = "Symbol"
			level.DisplayFormatString = New String(ChrW(&H00B7), 1)


			level = list.Levels(7)
			level.ParagraphProperties.LeftIndent = 1200
			level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging
			level.ParagraphProperties.FirstLineIndent = 75
			level.NumberingFormat = NumberingFormat.Bullet
			level.CharacterProperties.FontName = "Symbol"
			level.DisplayFormatString = New String(ChrW(&H006F), 1)


			level = list.Levels(8)
			level.ParagraphProperties.LeftIndent = 1350
			level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging
			level.ParagraphProperties.FirstLineIndent = 75
			level.NumberingFormat = NumberingFormat.Bullet
			level.CharacterProperties.FontName = "Symbol"
			level.DisplayFormatString = New String(ChrW(&H00B7), 1)

			' Create a numbering list. It is based on a previously defined abstract list with ID = 0.
			doc.NumberingLists.Add(0)

			'The main purpose of the Guard class is to validate parameters passed into a method. 
			'Methods exposed by the Guard class are designed to throw exceptions if a parameter being checked does not pass validation.
			Guard.Equals(doc.NumberingLists(doc.NumberingLists.Count - 1).Index, doc.NumberingLists.Count - 1)

			' Append list items
			AppendListParagraph(doc, "One", 0, 0, 0)
			AppendListParagraph(doc, "Two", 1, 0, 0)
			AppendListParagraph(doc, "Three", 2, 0, 0)
			AppendListParagraph(doc, "ThreeOne", 3, 1, 0)
			AppendListParagraph(doc, "ThreeTwo", 4, 1, 0)
			AppendListParagraph(doc, "ThreeTwoOne", 5, 2, 0)
			AppendListParagraph(doc, "ThreeTwoTwo", 6, 2, 0)
			AppendListParagraph(doc, "Four", 7, 0, 0)
			AppendListParagraph(doc, "FourOne", 8, 1, 0)
			AppendListParagraph(doc, "FourTwo", 9, 1, 0)
			AppendListParagraph(doc, "Five", 10, 0, 0)
			doc.AppendParagraph()

			doc.EndUpdate()
		End Sub

		Private Sub AppendListParagraph(ByVal doc As Document, ByVal text As String, ByVal paragraphIndex As Integer, ByVal numberingLevel As Integer, ByVal numberingIndex As Integer)
			doc.AppendText(text)
			doc.AppendParagraph()
			Dim paragraph As Paragraph = doc.Paragraphs(paragraphIndex)
			paragraph.ListIndex = numberingIndex
			paragraph.ListLevel = numberingLevel
		End Sub

	End Class
End Namespace
