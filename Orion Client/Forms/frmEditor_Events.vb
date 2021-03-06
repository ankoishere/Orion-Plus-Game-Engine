﻿Imports System.Windows.Forms

Public Class frmEditor_Events

#Region "Frm Code"
    Private Sub frmEditor_Events_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.ShiftKey Then VbKeyShift = True
    End Sub

    Private Sub frmEditor_Events_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.ShiftKey Then VbKeyShift = False
    End Sub
    Sub ClearConditionFrame()
        Dim i As Long

        cmbCondition_PlayerVarIndex.Enabled = False
        cmbCondition_PlayerVarIndex.Items.Clear()

        For i = 1 To MAX_VARIABLES
            cmbCondition_PlayerVarIndex.Items.Add(i & ". " & Variables(i))
        Next
        cmbCondition_PlayerVarIndex.SelectedIndex = 0
        cmbCondition_PlayerVarCompare.SelectedIndex = 0
        cmbCondition_PlayerVarCompare.Enabled = False
        txtCondition_PlayerVarCondition.Enabled = False
        txtCondition_PlayerVarCondition.Text = "0"
        cmbCondition_PlayerSwitch.Enabled = False
        cmbCondition_PlayerSwitch.Items.Clear()

        For i = 1 To MAX_SWITCHES
            cmbCondition_PlayerSwitch.Items.Add(i & ". " & Switches(i))
        Next
        cmbCondition_PlayerSwitch.SelectedIndex = 0
        cmbCondtion_PlayerSwitchCondition.Enabled = False
        cmbCondtion_PlayerSwitchCondition.SelectedIndex = 0
        cmbCondition_HasItem.Enabled = False
        cmbCondition_HasItem.Items.Clear()

        For i = 1 To MAX_ITEMS
            cmbCondition_HasItem.Items.Add(i & ". " & Trim$(Item(i).Name))
        Next
        cmbCondition_HasItem.SelectedIndex = 0
        scrlCondition_HasItem.Enabled = False
        scrlCondition_HasItem.Value = 1
        cmbCondition_ClassIs.Enabled = False
        cmbCondition_ClassIs.Items.Clear()

        For i = 1 To Max_Classes
            cmbCondition_ClassIs.Items.Add(i & ". " & CStr(Classes(i).Name))
        Next
        cmbCondition_ClassIs.SelectedIndex = 0
        cmbCondition_LearntSkill.Enabled = False
        cmbCondition_LearntSkill.Items.Clear()

        For i = 1 To MAX_SKILLS
            cmbCondition_LearntSkill.Items.Add(i & ". " & Trim$(Skill(i).Name))
        Next
        cmbCondition_LearntSkill.SelectedIndex = 0
        cmbCondition_LevelCompare.Enabled = False
        cmbCondition_LevelCompare.SelectedIndex = 0
        txtCondition_LevelAmount.Enabled = False
        txtCondition_LevelAmount.Text = "0"
        If cmbCondition_SelfSwitch.Items.Count > 0 Then
            cmbCondition_SelfSwitch.SelectedIndex = 0
        End If

        cmbCondition_SelfSwitch.Enabled = False

        If cmbCondition_SelfSwitchCondition.Items.Count > 0 Then
            cmbCondition_SelfSwitchCondition.SelectedIndex = 0
        End If

        cmbCondition_SelfSwitchCondition.Enabled = False
        scrlCondition_Quest.Enabled = False
        scrlCondition_Quest.Value = 1
        lblConditionQuest.Text = "Quest: 1"
        fraConditions_Quest.Visible = False
        optCondition_Quest0.Checked = True
        cmbCondition_General.Enabled = True
        cmbCondition_General.SelectedIndex = 0
        scrlCondition_QuestTask.Value = 1
        lblCondition_QuestTask.Text = "#1"


        cmbCondition_Gender.Enabled = False
    End Sub

    Public Sub InitEventEditorForm()
        Dim i As Long

        scrlShowTextFace.Maximum = NumFaces
        scrlShowChoicesFace.Maximum = NumFaces

        scrlWPMap.Maximum = MAX_MAPS

        cmbSwitch.Items.Clear()

        For i = 1 To MAX_SWITCHES
            cmbSwitch.Items.Add(i & ". " & Switches(i))
        Next
        cmbSwitch.SelectedIndex = 0
        cmbVariable.Items.Clear()

        For i = 1 To MAX_VARIABLES
            cmbVariable.Items.Add(i & ". " & Variables(i))
        Next
        cmbVariable.SelectedIndex = 0
        cmbChangeItemIndex.Items.Clear()

        For i = 1 To MAX_ITEMS
            cmbChangeItemIndex.Items.Add(Trim$(Item(i).Name))
        Next
        cmbChangeItemIndex.SelectedIndex = 0
        scrlChangeLevel.Minimum = 1
        scrlChangeLevel.Maximum = MAX_LEVELS
        scrlChangeLevel.Value = 1
        lblChangeLevel.Text = "Level: 1"
        cmbChangeSkills.Items.Clear()

        For i = 1 To MAX_SKILLS
            cmbChangeSkills.Items.Add(Trim$(Skill(i).Name))
        Next
        cmbChangeSkills.SelectedIndex = 0
        cmbChangeClass.Items.Clear()

        If Max_Classes > 0 Then
            For i = 1 To Max_Classes
                cmbChangeClass.Items.Add(Trim$(Classes(i).Name))
            Next
            cmbChangeClass.SelectedIndex = 0
        End If
        scrlChangeSprite.Maximum = NumCharacters
        cmbPlayAnim.Items.Clear()

        For i = 1 To MAX_ANIMATIONS
            cmbPlayAnim.Items.Add(i & ". " & Trim$(Animation(i).Name))
        Next
        cmbPlayAnim.SelectedIndex = 0

        cmbPlayBGM.Items.Clear()

        If UBound(MusicCache) > 0 Then
            For i = 1 To UBound(MusicCache)
                cmbPlayBGM.Items.Add(MusicCache(i))
            Next
            cmbPlayBGM.SelectedIndex = 0
        Else

        End If
        cmbPlaySound.Items.Clear()

        If UBound(SoundCache) > 0 Then
            For i = 1 To UBound(SoundCache)
                cmbPlaySound.Items.Add(SoundCache(i))
            Next
            cmbPlaySound.SelectedIndex = 0
        Else

        End If
        cmbOpenShop.Items.Clear()

        For i = 1 To MAX_SHOPS
            cmbOpenShop.Items.Add(i & ". " & Trim$(Shop(i).Name))
        Next
        cmbOpenShop.SelectedIndex = 0
        cmbSpawnNPC.Items.Clear()

        For i = 1 To MAX_MAP_NPCS
            If Map.Npc(i) > 0 Then
                cmbSpawnNPC.Items.Add(i & ". " & Trim$(Npc(Map.Npc(i)).Name))
            Else
                cmbSpawnNPC.Items.Add(i & ". ")
            End If
        Next
        cmbBeginQuest.Items.Clear()

        For i = 1 To MAX_QUESTS
            cmbBeginQuest.Items.Add(i & ". " & Trim$(Quest(i).Name))
        Next
        cmbEndQuest.Items.Clear()

        For i = 1 To MAX_QUESTS
            cmbEndQuest.Items.Add(i & ". " & Trim$(Quest(i).Name))
        Next
        cmbSpawnNPC.SelectedIndex = 0
        ScrlFogData0.Maximum = NumFogs
        cmbEventQuest.Items.Clear()
        cmbEventQuest.Items.Add("None")
        For i = 1 To MAX_QUESTS
            cmbEventQuest.Items.Add(i & ". " & Trim$(Quest(i).Name))
        Next
        'If NumPics > 0 Then
        'btnCommands45.Enabled = True
        'scrlShowPicture.Maximum = NumPics
        'cmbPicIndex.SelectedIndex = 0
        'Else

        'End If

        fraDialogue.Location = Panel2.Location
        fraDialogue.Visible = False

        EditorEvent_DrawGraphic()
    End Sub

    Private Sub frmEditor_Events_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Width = 858
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        EventEditorOK()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dispose()
    End Sub

    Private Sub lstvCommands_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstvCommands.SelectedIndexChanged
        Dim x As Long

        If lstvCommands.SelectedItems.Count = 0 Then Exit Sub

        fraDialogue.BringToFront()

        Select Case lstvCommands.SelectedItems(0).Index + 1
        'Messages

            'show text
            Case 1
                txtShowText.Text = vbNullString
                fraDialogue.Visible = True
                fraShowText.Visible = True
                scrlShowTextFace.Value = 0
                scrlShowTextFace.Maximum = NumFaces
                fraCommands.Visible = False
            'show choices
            Case 2
                txtChoicePrompt.Text = vbNullString
                txtChoices1.Text = vbNullString
                txtChoices2.Text = vbNullString
                txtChoices3.Text = vbNullString
                txtChoices4.Text = vbNullString
                scrlShowChoicesFace.Value = 0
                fraDialogue.Visible = True
                fraShowChoices.Visible = True
                fraCommands.Visible = False
            'chatbox text
            Case 3
                txtAddText_Text.Text = vbNullString
                scrlAddText_Colour.Value = 0
                optAddText_Player.Checked = True
                fraDialogue.Visible = True
                fraAddText.Visible = True
                fraCommands.Visible = False
            'chat bubble
            Case 4
                MsgBox("Sorry, no chatbubbles yet :(")
                Exit Sub
                txtChatbubbleText.Text = ""
                optChatBubbleTarget0.Checked = True
                cmbChatBubbleTarget.Visible = False
                fraDialogue.Visible = True
                fraShowChatBubble.Visible = True
                fraCommands.Visible = False
        'event progression
            'player variable
            Case 5
                txtVariableData0.Text = 0
                txtVariableData1.Text = 0
                txtVariableData2.Text = 0
                txtVariableData3.Text = 0
                txtVariableData4.Text = 0

                cmbVariable.SelectedIndex = 0
                optVariableAction0.Checked = True
                fraDialogue.Visible = True
                fraPlayerVariable.Visible = True
                fraCommands.Visible = False
            'player switch
            Case 6
                cmbPlayerSwitchSet.SelectedIndex = 0
                cmbSwitch.SelectedIndex = 0
                fraDialogue.Visible = True
                fraPlayerSwitch.Visible = True
                fraCommands.Visible = False
            'self switch
            Case 7
                cmbSetSelfSwitchTo.SelectedIndex = 0
                fraDialogue.Visible = True
                fraSetSelfSwitch.Visible = True
                fraCommands.Visible = False
        'flow control

            'conditional branch
            Case 8
                fraDialogue.Visible = True
                fraConditionalBranch.Visible = True
                optCondition0.Checked = True
                ClearConditionFrame()
                cmbCondition_PlayerVarIndex.Enabled = True
                cmbCondition_PlayerVarCompare.Enabled = True
                txtCondition_PlayerVarCondition.Enabled = True
                fraCommands.Visible = False
            'Exit Event Process
            Case 9
                AddCommand(EventType.evExitProcess)
                fraCommands.Visible = False
                fraDialogue.Visible = False
            'Label
            Case 10
                txtLabelName.Text = ""
                fraCreateLabel.Visible = True
                fraCommands.Visible = False
                fraDialogue.Visible = True
            'GoTo Label
            Case 11
                txtGotoLabel.Text = ""
                fraGoToLabel.Visible = True
                fraCommands.Visible = False
                fraDialogue.Visible = True
        'Player Control

            'Change Items
            Case 12
                cmbChangeItemIndex.SelectedIndex = 0
                optChangeItemSet.Checked = True
                txtChangeItemsAmount.Text = "0"
                fraDialogue.Visible = True
                fraChangeItems.Visible = True
                fraCommands.Visible = False
            'Restore Hp
            Case 13
                AddCommand(EventType.evRestoreHP)
                fraCommands.Visible = False
                fraDialogue.Visible = False
            'Restore Mp
            Case 14
                AddCommand(EventType.evRestoreMP)
                fraCommands.Visible = False
                fraDialogue.Visible = False
            'Level Up
            Case 15
                AddCommand(EventType.evLevelUp)
                fraCommands.Visible = False
                fraDialogue.Visible = False
            'Change Level
            Case 16
                scrlChangeLevel.Value = 1
                lblChangeLevel.Text = "Level: 1"
                fraDialogue.Visible = True
                fraChangeLevel.Visible = True
                fraCommands.Visible = False
            'Change Skills
            Case 17
                cmbChangeSkills.SelectedIndex = 0
                fraDialogue.Visible = True
                fraChangeSkills.Visible = True
                fraCommands.Visible = False
            'Change Class
            Case 18
                If Max_Classes > 0 Then
                    If cmbChangeClass.Items.Count = 0 Then
                        cmbChangeClass.Items.Clear()

                        For i = 1 To Max_Classes
                            cmbChangeClass.Items.Add(Trim$(Classes(i).Name))
                        Next
                        cmbChangeClass.SelectedIndex = 0
                    End If
                End If
                fraDialogue.Visible = True
                fraChangeClass.Visible = True
                fraCommands.Visible = False
            'Change Sprite
            Case 19
                scrlChangeSprite.Value = 1
                lblChangeSprite.Text = "Sprite: 1"
                fraDialogue.Visible = True
                fraChangeSprite.Visible = True
                fraCommands.Visible = False
            'Change Gender
            Case 20
                optChangeSexMale.Checked = True
                fraDialogue.Visible = True
                fraChangeGender.Visible = True
                fraCommands.Visible = False
            'Change PK
            Case 21
                optChangePKYes.Checked = True
                fraDialogue.Visible = True
                fraChangePK.Visible = True
                fraCommands.Visible = False
            'Give Exp
            Case 22
                scrlGiveExp.Value = 0
                lblGiveExp.Text = "Give Exp: 0"
                fraDialogue.Visible = True
                fraGiveExp.Visible = True
                fraCommands.Visible = False
        'Movement

            'Warp Player
            Case 23
                scrlWPMap.Value = 0
                scrlWPX.Value = 0
                scrlWPY.Value = 0
                cmbWarpPlayerDir.SelectedIndex = 0
                fraDialogue.Visible = True
                fraPlayerWarp.Visible = True
                fraCommands.Visible = False
            'Set Move Route
            Case 24
                fraMoveRoute.Visible = True
                lstMoveRoute.Items.Clear()
                cmbEvent.Items.Clear()
                ReDim ListOfEvents(0 To Map.EventCount)
                ListOfEvents(0) = EditorEvent
                cmbEvent.Items.Add("This Event")
                cmbEvent.SelectedIndex = 0
                cmbEvent.Enabled = True
                For i = 1 To Map.EventCount
                    If i <> EditorEvent Then
                        cmbEvent.Items.Add(Trim$(Map.Events(i).Name))
                        x = x + 1
                        ListOfEvents(x) = i
                    End If
                Next
                IsMoveRouteCommand = True
                chkIgnoreMove.Checked = 0
                chkRepeatRoute.Checked = 0
                TempMoveRouteCount = 0
                ReDim TempMoveRoute(0)
                pnlMoveRoute.Width = 841
                pnlMoveRoute.Height = 636
                pnlMoveRoute.Visible = True
                pnlMoveRoute.BringToFront()
                fraCommands.Visible = False
            'Wait for Route Completion
            Case 25
                cmbMoveWait.Items.Clear()
                ReDim ListOfEvents(0 To Map.EventCount)
                ListOfEvents(0) = EditorEvent
                cmbMoveWait.Items.Add("This Event")
                cmbMoveWait.SelectedIndex = 0
                cmbMoveWait.Enabled = True
                For i = 1 To Map.EventCount
                    If i <> EditorEvent Then
                        cmbMoveWait.Items.Add(Trim$(Map.Events(i).Name))
                        x = x + 1
                        ListOfEvents(x) = i
                    End If
                Next
                fraDialogue.Visible = True
                fraMoveRouteWait.Visible = True
                fraCommands.Visible = False
            'Spawn Npc
            Case 26
                'lets populate the combobox
                cmbSpawnNPC.Items.Clear()
                For i = 1 To MAX_NPCS
                    cmbSpawnNPC.Items.Add(Trim(Npc(i).Name))
                Next
                cmbSpawnNPC.SelectedIndex = 0
                fraDialogue.Visible = True
                fraSpawnNpc.Visible = True
                fraCommands.Visible = False
            'Hold Player
            Case 27
                AddCommand(EventType.evHoldPlayer)
                fraCommands.Visible = False
                fraDialogue.Visible = False
            'Release Player
            Case 28
                AddCommand(EventType.evReleasePlayer)
                fraCommands.Visible = False
                fraDialogue.Visible = False
        'Animation

            'Play Animation
            Case 29
                cmbPlayAnimEvent.Items.Clear()

                For i = 1 To Map.EventCount
                    cmbPlayAnimEvent.Items.Add(i & ". " & Trim$(Map.Events(i).Name))
                Next
                cmbPlayAnimEvent.SelectedIndex = 0
                optPlayAnimPlayer.Checked = True
                cmbPlayAnim.SelectedIndex = 0
                lblPlayAnimX.Text = "Map Tile X: 0"
                lblPlayAnimY.Text = "Map Tile Y: 0"
                scrlPlayAnimTileX.Value = 0
                scrlPlayAnimTileY.Value = 0
                scrlPlayAnimTileX.Maximum = Map.MaxX
                scrlPlayAnimTileY.Maximum = Map.MaxY
                fraDialogue.Visible = True
                fraPlayAnimation.Visible = True
                fraCommands.Visible = False
                lblPlayAnimX.Visible = False
                lblPlayAnimY.Visible = False
                scrlPlayAnimTileX.Visible = False
                scrlPlayAnimTileY.Visible = False
                cmbPlayAnimEvent.Visible = False
        'Quests

            'Begin Quest
            Case 30
                cmbBeginQuest.SelectedIndex = 0
                fraDialogue.Visible = True
                fraBeginQuest.Visible = True
                fraCommands.Visible = False
            'Complete Give/Talk Task
            Case 31
                scrlCompleteQuestTaskQuest.Value = 1
                scrlCompleteQuestTask.Value = 1
                fraDialogue.Visible = True
                fraCompleteTask.Visible = True
                fraCommands.Visible = False
            'End Quest
            Case 32
                cmbEndQuest.SelectedIndex = 0
                fraDialogue.Visible = True
                fraEndQuest.Visible = True
                fraCommands.Visible = False
        'Map Functions

            'Set Fog
            Case 33
                ScrlFogData0.Value = 0
                ScrlFogData1.Value = 0
                ScrlFogData2.Value = 0
                fraDialogue.Visible = True
                fraSetFog.Visible = True
                fraCommands.Visible = False
            'Set Weather
            Case 34
                CmbWeather.SelectedIndex = 0
                scrlWeatherIntensity.Value = 0
                fraDialogue.Visible = True
                fraSetWeather.Visible = True
                fraCommands.Visible = False
            'Set Map Tinting
            Case 35
                scrlMapTintData0.Value = 0
                scrlMapTintData1.Value = 0
                scrlMapTintData2.Value = 0
                scrlMapTintData3.Value = 0
                fraDialogue.Visible = True
                fraMapTint.Visible = True
                fraCommands.Visible = False
        'Music and Sound

            'PlayBGM
            Case 36
                cmbPlayBGM.SelectedIndex = 0
                fraDialogue.Visible = True
                fraPlayBGM.Visible = True
                fraCommands.Visible = False
            'Fadeout BGM
            Case 37
                AddCommand(EventType.evFadeoutBGM)
                fraCommands.Visible = False
                fraDialogue.Visible = False
            'Play Sound
            Case 38
                cmbPlaySound.SelectedIndex = 0
                fraDialogue.Visible = True
                fraPlaySound.Visible = True
                fraCommands.Visible = False
            'Stop Sounds
            Case 39
                AddCommand(EventType.evStopSound)
                fraCommands.Visible = False
                fraDialogue.Visible = False
        'Etc...

            'Wait
            Case 40
                scrlWaitAmount.Value = 1
                fraDialogue.Visible = True
                fraSetWait.Visible = True
                fraCommands.Visible = False
            'Set Access
            Case 41
                cmbSetAccess.SelectedIndex = 0
                fraDialogue.Visible = True
                fraSetAccess.Visible = True
                fraCommands.Visible = False
            'Custom Script
            Case 42
                scrlCustomScript.Value = 1
                fraDialogue.Visible = True
                fraCustomScript.Visible = True
                fraCommands.Visible = False
            'Shop, bank etc

            'Open bank
            Case 43
                AddCommand(EventType.evOpenBank)
                fraCommands.Visible = False
                fraDialogue.Visible = False
            'Open shop
            Case 44
                fraDialogue.Visible = True
                fraOpenShop.Visible = True
                cmbOpenShop.SelectedIndex = 0
                fraCommands.Visible = False
            'Open Mail
            Case 45
                AddCommand(EventType.evOpenMail)
                fraCommands.Visible = False
                fraDialogue.Visible = False
        'cutscene options

            'Fade in
            Case 46
                AddCommand(EventType.evFadeIn)
                fraCommands.Visible = False
                fraDialogue.Visible = False
            'Fade out
            Case 47
                AddCommand(EventType.evFadeOut)
                fraCommands.Visible = False
                fraDialogue.Visible = False
            'Flash white
            Case 48
                AddCommand(EventType.evFlashWhite)
                fraCommands.Visible = False
                fraDialogue.Visible = False
            'Show pic
            Case 49
                cmbPicIndex.SelectedIndex = 0
                scrlShowPicture.Value = 1
                optPic1.Checked = 1
                txtPicOffset1.Text = 0
                txtPicOffset2.Text = 0
                fraDialogue.Visible = True
                fraShowPic.Visible = True
                fraCommands.Visible = False
            'Hide pic
            Case 50
                cmbHidePic.SelectedIndex = 0
                fraDialogue.Visible = True
                fraHidePic.Visible = True
                fraCommands.Visible = False

        End Select

    End Sub

    Private Sub btnCancelCommand_Click(sender As Object, e As EventArgs) Handles btnCancelCommand.Click
        fraCommands.Visible = False
    End Sub
#End Region

#Region "Page Buttons"
    Private Sub btnNewPage_Click(sender As Object, e As EventArgs) Handles btnNewPage.Click
        Dim pageCount As Long, i As Long

        If chkGlobal.Checked = True Then
            MsgBox("You cannot have multiple pages on global events!")
            Exit Sub
        End If


        pageCount = tmpEvent.PageCount + 1

        ' redim the array
        ReDim Preserve tmpEvent.Pages(pageCount)

        tmpEvent.PageCount = pageCount

        ' set the tabs
        tabPages.TabPages.Clear()

        For i = 1 To tmpEvent.PageCount
            tabPages.TabPages.Add(Str(i))
        Next
        btnDeletePage.Enabled = True
    End Sub

    Private Sub btnCopyPage_Click(sender As Object, e As EventArgs) Handles btnCopyPage.Click
        CopyEventPage = tmpEvent.Pages(curPageNum)
        btnPastePage.Enabled = True
    End Sub

    Private Sub btnPastePage_Click(sender As Object, e As EventArgs) Handles btnPastePage.Click
        tmpEvent.Pages(curPageNum) = CopyEventPage
        EventEditorLoadPage(curPageNum)
    End Sub

    Private Sub btnDeletePage_Click(sender As Object, e As EventArgs) Handles btnDeletePage.Click
        tmpEvent.Pages(curPageNum) = Nothing
        ' move everything else down a notch
        If curPageNum < tmpEvent.PageCount Then
            For i = curPageNum To tmpEvent.PageCount - 1
                tmpEvent.Pages(i + 1) = tmpEvent.Pages(i)
            Next
        End If
        tmpEvent.PageCount = tmpEvent.PageCount - 1
        ' set the tabs
        tabPages.TabPages.Clear()

        For i = 1 To tmpEvent.PageCount
            tabPages.TabPages.Add("0", Str(i), "")
        Next
        ' set the tab back
        If curPageNum <= tmpEvent.PageCount Then
            tabPages.SelectedIndex = tabPages.TabPages.IndexOfKey(curPageNum)
        Else
            tabPages.SelectedIndex = tabPages.TabPages.IndexOfKey(tmpEvent.PageCount)
        End If
        ' make sure we disable
        If tmpEvent.PageCount <= 1 Then
            btnDeletePage.Enabled = False
        End If

    End Sub

    Private Sub btnClearPage_Click(sender As Object, e As EventArgs) Handles btnClearPage.Click
        tmpEvent.Pages(curPageNum) = Nothing
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        tmpEvent.Name = Trim$(txtName.Text)
    End Sub
#End Region

#Region "Conditions"
    Private Sub chkPlayerVar_CheckedChanged(sender As Object, e As EventArgs) Handles chkPlayerVar.CheckedChanged
        If chkPlayerVar.Checked = 0 Then
            cmbPlayerVar.Enabled = False
            txtPlayerVariable.Enabled = False
            cmbPlayervarCompare.Enabled = False
            tmpEvent.Pages(curPageNum).chkVariable = 0
        Else
            cmbPlayerVar.Enabled = True
            txtPlayerVariable.Enabled = True
            cmbPlayervarCompare.Enabled = True
            tmpEvent.Pages(curPageNum).chkVariable = 1
        End If
    End Sub

    Private Sub cmbPlayerVar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlayerVar.SelectedIndexChanged
        If cmbPlayerVar.SelectedIndex = -1 Then Exit Sub
        tmpEvent.Pages(curPageNum).VariableIndex = cmbPlayerVar.SelectedIndex
    End Sub

    Private Sub cmbPlayervarCompare_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlayervarCompare.SelectedIndexChanged
        If cmbPlayervarCompare.SelectedIndex = -1 Then Exit Sub
        tmpEvent.Pages(curPageNum).VariableCompare = cmbPlayervarCompare.SelectedIndex
    End Sub

    Private Sub txtPlayerVariable_TextChanged(sender As Object, e As EventArgs) Handles txtPlayerVariable.TextChanged
        tmpEvent.Pages(curPageNum).VariableCondition = Val(Trim$(txtPlayerVariable.Text))
    End Sub

    Private Sub chkPlayerSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles chkPlayerSwitch.CheckedChanged
        If chkPlayerSwitch.Checked = 0 Then
            cmbPlayerSwitch.Enabled = False
            cmbPlayerSwitchCompare.Enabled = False
            tmpEvent.Pages(curPageNum).chkSwitch = 0
        Else
            cmbPlayerSwitch.Enabled = True
            cmbPlayerSwitchCompare.Enabled = True
            tmpEvent.Pages(curPageNum).chkSwitch = 1
        End If
    End Sub

    Private Sub cmbPlayerSwitch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlayerSwitch.SelectedIndexChanged
        If cmbPlayerSwitch.SelectedIndex = -1 Then Exit Sub
        tmpEvent.Pages(curPageNum).SwitchIndex = cmbPlayerSwitch.SelectedIndex
    End Sub

    Private Sub cmbPlayerSwitchCompare_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlayerSwitchCompare.SelectedIndexChanged
        If cmbPlayerSwitchCompare.SelectedIndex = -1 Then Exit Sub
        tmpEvent.Pages(curPageNum).SwitchCompare = cmbPlayerSwitchCompare.SelectedIndex
    End Sub

    Private Sub chkHasItem_CheckedChanged(sender As Object, e As EventArgs) Handles chkHasItem.CheckedChanged
        tmpEvent.Pages(curPageNum).chkHasItem = chkHasItem.Checked
        If chkHasItem.Checked = 0 Then cmbHasItem.Enabled = False Else cmbHasItem.Enabled = True
    End Sub

    Private Sub cmbHasItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHasItem.SelectedIndexChanged
        If cmbHasItem.SelectedIndex = -1 Then Exit Sub
        tmpEvent.Pages(curPageNum).HasItemIndex = cmbHasItem.SelectedIndex
        tmpEvent.Pages(curPageNum).HasItemAmount = scrlCondition_HasItem.Value
    End Sub

    Private Sub chkSelfSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelfSwitch.CheckedChanged
        If chkSelfSwitch.Checked = 0 Then
            cmbSelfSwitch.Enabled = False
            cmbSelfSwitchCompare.Enabled = False
            tmpEvent.Pages(curPageNum).chkSelfSwitch = 0
        Else
            cmbSelfSwitch.Enabled = True
            cmbSelfSwitchCompare.Enabled = True
            tmpEvent.Pages(curPageNum).chkSelfSwitch = 1
        End If
    End Sub

    Private Sub cmbSelfSwitch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelfSwitch.SelectedIndexChanged
        If cmbSelfSwitch.SelectedIndex = -1 Then Exit Sub
        tmpEvent.Pages(curPageNum).SelfSwitchIndex = cmbSelfSwitch.SelectedIndex
    End Sub

    Private Sub cmbSelfSwitchCompare_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelfSwitchCompare.SelectedIndexChanged
        If cmbSelfSwitchCompare.SelectedIndex = -1 Then Exit Sub
        tmpEvent.Pages(curPageNum).SelfSwitchCompare = cmbSelfSwitchCompare.SelectedIndex
    End Sub

#End Region

#Region "Graphic"
    Private Sub picGraphic_Click(sender As Object, e As EventArgs) Handles picGraphic.Click
        fraGraphic.Width = 841
        fraGraphic.Height = 636
        fraGraphic.BringToFront()
        fraGraphic.Visible = True
        GraphicSelType = 0
    End Sub

    Private Sub cmbGraphic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGraphic.SelectedIndexChanged
        If cmbGraphic.SelectedIndex = -1 Then Exit Sub
        tmpEvent.Pages(curPageNum).GraphicType = cmbGraphic.SelectedIndex
        ' set the max on the scrollbar
        Select Case cmbGraphic.SelectedIndex
            Case 0 ' None
                scrlGraphic.Value = 1
                scrlGraphic.Enabled = False
            Case 1 ' character
                scrlGraphic.Maximum = NumCharacters
                scrlGraphic.Enabled = True
            Case 2 ' Tileset
                scrlGraphic.Maximum = NumTileSets
                scrlGraphic.Enabled = True
        End Select
        If scrlGraphic.Value = 0 Then
            lblGraphic.Text = "Number: None"
        Else
            lblGraphic.Text = "Number: " & scrlGraphic.Value
        End If
        If tmpEvent.Pages(curPageNum).GraphicType = 1 Then
            If Me.scrlGraphic.Value <= 0 Or Me.scrlGraphic.Value > NumCharacters Then Exit Sub

        ElseIf tmpEvent.Pages(curPageNum).GraphicType = 2 Then
            If Me.scrlGraphic.Value <= 0 Or Me.scrlGraphic.Value > NumTileSets Then Exit Sub

        End If
        EditorEvent_DrawGraphic()
    End Sub

    Private Sub scrlGraphic_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlGraphic.Scroll
        If scrlGraphic.Value = 0 Then
            lblGraphic.Text = "Number: None"
        Else
            lblGraphic.Text = "Number: " & scrlGraphic.Value
        End If
        EditorEvent_DrawGraphic()
        'cmbGraphic_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub picGraphicSel_Click(sender As Object, e As MouseEventArgs) Handles picGraphicSel.Click
        Dim X As Long
        Dim Y As Long

        X = e.Location.X
        Y = e.Location.Y

        Dim selW As Long = Math.Ceiling(X \ PIC_X) - GraphicSelX
        Dim selH As Long = Math.Ceiling(Y \ PIC_Y) - GraphicSelY

        If Me.cmbGraphic.SelectedIndex = 2 Then
            'Tileset... hard one....
            If Control.ModifierKeys = Keys.Shift Then
                If GraphicSelX > -1 And GraphicSelY > -1 Then
                    If selW >= 0 And selH >= 0 Then
                        GraphicSelX2 = selW + 1
                        GraphicSelY2 = selH + 1
                    End If
                End If
            Else
                GraphicSelX = X \ PIC_X
                GraphicSelY = Y \ PIC_Y
                GraphicSelX2 = 1
                GraphicSelY2 = 1
            End If
        ElseIf Me.cmbGraphic.SelectedIndex = 1 Then
            GraphicSelX = X
            GraphicSelY = Y
            GraphicSelX2 = 0
            GraphicSelY2 = 0
            If Me.scrlGraphic.Value <= 0 Or Me.scrlGraphic.Value > NumCharacters Then Exit Sub
            For i = 0 To 3
                If GraphicSelX >= ((CharacterGFXInfo(Me.scrlGraphic.Value).width / 4) * i) And GraphicSelX < ((CharacterGFXInfo(Me.scrlGraphic.Value).width / 4) * (i + 1)) Then
                    GraphicSelX = i
                End If
            Next
            For i = 0 To 3
                If GraphicSelY >= ((CharacterGFXInfo(Me.scrlGraphic.Value).height / 4) * i) And GraphicSelY < ((CharacterGFXInfo(Me.scrlGraphic.Value).height / 4) * (i + 1)) Then
                    GraphicSelY = i
                End If
            Next
        End If
        EditorEvent_DrawGraphic()
    End Sub

    Private Sub btnGraphicOk_Click(sender As Object, e As EventArgs) Handles btnGraphicOk.Click
        If GraphicSelType = 0 Then
            tmpEvent.Pages(curPageNum).GraphicType = cmbGraphic.SelectedIndex
            tmpEvent.Pages(curPageNum).Graphic = scrlGraphic.Value
            tmpEvent.Pages(curPageNum).GraphicX = GraphicSelX
            tmpEvent.Pages(curPageNum).GraphicY = GraphicSelY
            tmpEvent.Pages(curPageNum).GraphicX2 = GraphicSelX2
            tmpEvent.Pages(curPageNum).GraphicY2 = GraphicSelY2
        Else
            AddMoveRouteCommand(42)
            GraphicSelType = 0
        End If
        fraGraphic.Visible = False
    End Sub

    Private Sub btnGraphicCancel_Click(sender As Object, e As EventArgs) Handles btnGraphicCancel.Click
        fraGraphic.Visible = False
    End Sub
#End Region

#Region "Movement"
    Private Sub cmbMoveType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMoveType.SelectedIndexChanged
        If cmbMoveType.SelectedIndex = -1 Then Exit Sub
        tmpEvent.Pages(curPageNum).MoveType = cmbMoveType.SelectedIndex
        If cmbMoveType.SelectedIndex = 2 Then
            btnMoveRoute.Enabled = True
        Else
            btnMoveRoute.Enabled = False
        End If
    End Sub

    Private Sub btnMoveRoute_Click(sender As Object, e As EventArgs) Handles btnMoveRoute.Click
        pnlMoveRoute.BringToFront()
        lstMoveRoute.Items.Clear()
        cmbEvent.Items.Clear()
        cmbEvent.Items.Add("This Event")
        cmbEvent.SelectedIndex = 0
        cmbEvent.Enabled = False
        IsMoveRouteCommand = False
        chkIgnoreMove.Checked = tmpEvent.Pages(curPageNum).IgnoreMoveRoute
        chkRepeatRoute.Checked = tmpEvent.Pages(curPageNum).RepeatMoveRoute
        TempMoveRouteCount = tmpEvent.Pages(curPageNum).MoveRouteCount

        'Will it let me do this?
        TempMoveRoute = tmpEvent.Pages(curPageNum).MoveRoute
        For i = 1 To TempMoveRouteCount
            Select Case TempMoveRoute(i).Index
                Case 1
                    lstMoveRoute.Items.Add("Move Up")
                Case 2
                    lstMoveRoute.Items.Add("Move Down")
                Case 3
                    lstMoveRoute.Items.Add("Move Left")
                Case 4
                    lstMoveRoute.Items.Add("Move Right")
                Case 5
                    lstMoveRoute.Items.Add("Move Randomly")
                Case 6
                    lstMoveRoute.Items.Add("Move Towards Player")
                Case 7
                    lstMoveRoute.Items.Add("Move Away From Player")
                Case 8
                    lstMoveRoute.Items.Add("Step Forward")
                Case 9
                    lstMoveRoute.Items.Add("Step Back")
                Case 10
                    lstMoveRoute.Items.Add("Wait 100ms")
                Case 11
                    lstMoveRoute.Items.Add("Wait 500ms")
                Case 12
                    lstMoveRoute.Items.Add("Wait 1000ms")
                Case 13
                    lstMoveRoute.Items.Add("Turn Up")
                Case 14
                    lstMoveRoute.Items.Add("Turn Down")
                Case 15
                    lstMoveRoute.Items.Add("Turn Left")
                Case 16
                    lstMoveRoute.Items.Add("Turn Right")
                Case 17
                    lstMoveRoute.Items.Add("Turn 90 Degrees To the Right")
                Case 18
                    lstMoveRoute.Items.Add("Turn 90 Degrees To the Left")
                Case 19
                    lstMoveRoute.Items.Add("Turn Around 180 Degrees")
                Case 20
                    lstMoveRoute.Items.Add("Turn Randomly")
                Case 21
                    lstMoveRoute.Items.Add("Turn Towards Player")
                Case 22
                    lstMoveRoute.Items.Add("Turn Away from Player")
                Case 23
                    lstMoveRoute.Items.Add("Set Speed 8x Slower")
                Case 24
                    lstMoveRoute.Items.Add("Set Speed 4x Slower")
                Case 25
                    lstMoveRoute.Items.Add("Set Speed 2x Slower")
                Case 26
                    lstMoveRoute.Items.Add("Set Speed to Normal")
                Case 27
                    lstMoveRoute.Items.Add("Set Speed 2x Faster")
                Case 28
                    lstMoveRoute.Items.Add("Set Speed 4x Faster")
                Case 29
                    lstMoveRoute.Items.Add("Set Frequency Lowest")
                Case 30
                    lstMoveRoute.Items.Add("Set Frequency Lower")
                Case 31
                    lstMoveRoute.Items.Add("Set Frequency Normal")
                Case 32
                    lstMoveRoute.Items.Add("Set Frequency Higher")
                Case 33
                    lstMoveRoute.Items.Add("Set Frequency Highest")
                Case 34
                    lstMoveRoute.Items.Add("Turn On Walking Animation")
                Case 35
                    lstMoveRoute.Items.Add("Turn Off Walking Animation")
                Case 36
                    lstMoveRoute.Items.Add("Turn On Fixed Direction")
                Case 37
                    lstMoveRoute.Items.Add("Turn Off Fixed Direction")
                Case 38
                    lstMoveRoute.Items.Add("Turn On Walk Through")
                Case 39
                    lstMoveRoute.Items.Add("Turn Off Walk Through")
                Case 40
                    lstMoveRoute.Items.Add("Set Position Below Player")
                Case 41
                    lstMoveRoute.Items.Add("Set Position at Player Level")
                Case 42
                    lstMoveRoute.Items.Add("Set Position Above Player")
                Case 43
                    lstMoveRoute.Items.Add("Set Graphic")
            End Select
        Next
        pnlMoveRoute.Width = 841
        pnlMoveRoute.Height = 636
        pnlMoveRoute.Visible = True

    End Sub

    Private Sub cmbMoveSpeed_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMoveSpeed.SelectedIndexChanged
        If cmbMoveSpeed.SelectedIndex = -1 Then Exit Sub
        tmpEvent.Pages(curPageNum).MoveSpeed = cmbMoveSpeed.SelectedIndex
    End Sub

    Private Sub cmbMoveFreq_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMoveFreq.SelectedIndexChanged
        If cmbMoveFreq.SelectedIndex = -1 Then Exit Sub
        tmpEvent.Pages(curPageNum).MoveFreq = cmbMoveFreq.SelectedIndex
    End Sub


#End Region

#Region "Positioning"
    Private Sub cmbPositioning_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPositioning.SelectedIndexChanged
        If cmbPositioning.SelectedIndex = -1 Then Exit Sub
        tmpEvent.Pages(curPageNum).Position = cmbPositioning.SelectedIndex
    End Sub
#End Region

#Region "Trigger"
    Private Sub cmbTrigger_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTrigger.SelectedIndexChanged
        If cmbTrigger.SelectedIndex = -1 Then Exit Sub
        tmpEvent.Pages(curPageNum).Trigger = cmbTrigger.SelectedIndex
    End Sub
#End Region

#Region "Global"
    Private Sub chkGlobal_CheckedChanged(sender As Object, e As EventArgs) Handles chkGlobal.CheckedChanged
        If tmpEvent.PageCount > 1 Then
            If MsgBox("If you set the event to global you will lose all pages except for your first one. Do you want to continue?", vbYesNo) = vbNo Then
                Exit Sub
            End If
        End If
        If chkGlobal.Checked = True Then
            tmpEvent.Globals = 1
        Else
            tmpEvent.Globals = 0
        End If

        tmpEvent.PageCount = 1
        curPageNum = 1
        Me.tabPages.TabPages.Clear()

        For i = 1 To tmpEvent.PageCount
            Me.tabPages.TabPages.Add("0", Str(i), "0")
        Next
        EventEditorLoadPage(curPageNum)
    End Sub
#End Region

#Region "QuestIcon"
    Private Sub cmbEventQuest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEventQuest.SelectedIndexChanged
        tmpEvent.Pages(curPageNum).Questnum = cmbEventQuest.SelectedIndex
    End Sub
#End Region

#Region "Options"
    Private Sub chkWalkAnim_CheckedChanged(sender As Object, e As EventArgs) Handles chkWalkAnim.CheckedChanged
        If chkWalkAnim.Checked = True Then
            tmpEvent.Pages(curPageNum).WalkAnim = 1
        Else
            tmpEvent.Pages(curPageNum).WalkAnim = 0
        End If

    End Sub

    Private Sub chkDirFix_CheckedChanged(sender As Object, e As EventArgs) Handles chkDirFix.CheckedChanged
        If chkDirFix.Checked = True Then
            tmpEvent.Pages(curPageNum).DirFix = 1
        Else
            tmpEvent.Pages(curPageNum).DirFix = 0
        End If

    End Sub

    Private Sub chkWalkThrough_CheckedChanged(sender As Object, e As EventArgs) Handles chkWalkThrough.CheckedChanged
        If chkWalkThrough.Checked = True Then
            tmpEvent.Pages(curPageNum).WalkThrough = 1
        Else
            tmpEvent.Pages(curPageNum).WalkThrough = 0
        End If

    End Sub

    Private Sub chkShowName_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowName.CheckedChanged
        If chkShowName.Checked = True Then
            tmpEvent.Pages(curPageNum).ShowName = 1
        Else
            tmpEvent.Pages(curPageNum).ShowName = 0
        End If

    End Sub
#End Region

#Region "Commands"
    Private Sub lstCommands_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCommands.SelectedIndexChanged
        curCommand = lstCommands.SelectedIndex + 1
    End Sub

    Private Sub btnAddCommand_Click(sender As Object, e As EventArgs) Handles btnAddCommand.Click
        If lstCommands.SelectedIndex > -1 Then
            isEdit = False
            'tabPages.SelectedTab = TabPage
            fraCommands.Visible = True
        End If
    End Sub

    Private Sub btnEditCommand_Click(sender As Object, e As EventArgs) Handles btnEditCommand.Click
        If lstCommands.SelectedIndex > -1 Then
            EditEventCommand()
        End If
    End Sub

    Private Sub btnDeleteComand_Click(sender As Object, e As EventArgs) Handles btnDeleteComand.Click
        If lstCommands.SelectedIndex > -1 Then
            DeleteEventCommand()
        End If

    End Sub

    Private Sub btnClearCommand_Click(sender As Object, e As EventArgs) Handles btnClearCommand.Click
        If MsgBox("Are you sure you want to clear all event commands?", vbYesNo, "Clear Event Commands?") = vbYes Then
            ClearEventCommands()
        End If
    End Sub
#End Region

#Region "Variables/Switches"
    'Renaming Variables/Switches
    Private Sub btnLabeling_Click(sender As Object, e As EventArgs) Handles btnLabeling.Click
        pnlVariableSwitches.Visible = True
        pnlVariableSwitches.BringToFront()
        fraLabeling.Visible = True
        pnlVariableSwitches.Width = 849
        pnlVariableSwitches.Height = 593
        lstSwitches.Items.Clear()

        For i = 1 To MAX_SWITCHES
            lstSwitches.Items.Add(CStr(i) & ". " & Trim$(Switches(i)))
        Next
        lstSwitches.SelectedIndex = 0
        lstVariables.Items.Clear()

        For i = 1 To MAX_VARIABLES
            lstVariables.Items.Add(CStr(i) & ". " & Trim$(Variables(i)))
        Next
        lstVariables.SelectedIndex = 0


    End Sub

    Private Sub btnRename_Ok_Click(sender As Object, e As EventArgs) Handles btnRename_Ok.Click
        Select Case RenameType
            Case 1
                'Variable
                If RenameIndex > 0 And RenameIndex <= MAX_VARIABLES + 1 Then
                    Variables(RenameIndex) = txtRename.Text
                    FraRenaming.Visible = False
                    RenameType = 0
                    RenameIndex = 0
                End If
            Case 2
                'Switch
                If RenameIndex > 0 And RenameIndex <= MAX_SWITCHES + 1 Then
                    Switches(RenameIndex) = txtRename.Text
                    FraRenaming.Visible = False
                    RenameType = 0
                    RenameIndex = 0
                End If
        End Select
        lstSwitches.Items.Clear()

        For i = 1 To MAX_SWITCHES
            lstSwitches.Items.Add(CStr(i) & ". " & Trim$(Switches(i)))
        Next
        lstSwitches.SelectedIndex = 0
        lstVariables.Items.Clear()

        For i = 1 To MAX_VARIABLES
            lstVariables.Items.Add(CStr(i) & ". " & Trim$(Variables(i)))
        Next
        lstVariables.SelectedIndex = 0
    End Sub

    Private Sub btnRename_Cancel_Click(sender As Object, e As EventArgs) Handles btnRename_Cancel.Click
        FraRenaming.Visible = False
        RenameType = 0
        RenameIndex = 0
        lstSwitches.Items.Clear()

        For i = 1 To MAX_SWITCHES
            lstSwitches.Items.Add(CStr(i) & ". " & Trim$(Switches(i)))
        Next
        lstSwitches.SelectedIndex = 0
        lstVariables.Items.Clear()

        For i = 1 To MAX_VARIABLES
            lstVariables.Items.Add(CStr(i) & ". " & Trim$(Variables(i)))
        Next
        lstVariables.SelectedIndex = 0
    End Sub

    Private Sub txtRename_TextChanged(sender As Object, e As EventArgs) Handles txtRename.TextChanged
        tmpEvent.Name = Trim$(txtName.Text)
    End Sub

    Private Sub lstVariables_DoubleClick(sender As Object, e As EventArgs) Handles lstVariables.DoubleClick
        If lstVariables.SelectedIndex > -1 And lstVariables.SelectedIndex < MAX_VARIABLES Then
            FraRenaming.Visible = True
            lblEditing.Text = "Editing Variable #" & CStr(lstVariables.SelectedIndex + 1)
            txtRename.Text = Variables(lstVariables.SelectedIndex + 1)
            RenameType = 1
            RenameIndex = lstVariables.SelectedIndex + 1
        End If
    End Sub

    Private Sub lstSwitches_DoubleClick(sender As Object, e As EventArgs) Handles lstSwitches.DoubleClick
        If lstSwitches.SelectedIndex > -1 And lstSwitches.SelectedIndex < MAX_SWITCHES Then
            FraRenaming.Visible = True
            lblEditing.Text = "Editing Switch #" & CStr(lstSwitches.SelectedIndex + 1)
            txtRename.Text = Switches(lstSwitches.SelectedIndex + 1)
            RenameType = 2
            RenameIndex = lstSwitches.SelectedIndex + 1
        End If
    End Sub

    Private Sub btnRenameVariable_Click(sender As Object, e As EventArgs) Handles btnRenameVariable.Click
        If lstVariables.SelectedIndex > -1 And lstVariables.SelectedIndex < MAX_VARIABLES Then
            FraRenaming.Visible = True
            lblEditing.Text = "Editing Variable #" & CStr(lstVariables.SelectedIndex + 1)
            txtRename.Text = Variables(lstVariables.SelectedIndex + 1)
            RenameType = 1
            RenameIndex = lstVariables.SelectedIndex + 1
        End If
    End Sub

    Private Sub btnRenameSwitch_Click(sender As Object, e As EventArgs) Handles btnRenameSwitch.Click
        If lstSwitches.SelectedIndex > -1 And lstSwitches.SelectedIndex < MAX_SWITCHES Then
            FraRenaming.Visible = True
            lblEditing.Text = "Editing Switch #" & CStr(lstSwitches.SelectedIndex + 1)
            txtRename.Text = Switches(lstSwitches.SelectedIndex + 1)
            RenameType = 2
            RenameIndex = lstSwitches.SelectedIndex + 1
        End If
    End Sub

    Private Sub btnLabel_Ok_Click(sender As Object, e As EventArgs) Handles btnLabel_Ok.Click
        pnlVariableSwitches.Visible = False
        fraLabeling.Visible = False
        SendSwitchesAndVariables()
    End Sub

    Private Sub btnLabel_Cancel_Click(sender As Object, e As EventArgs) Handles btnLabel_Cancel.Click
        pnlVariableSwitches.Visible = False
        fraLabeling.Visible = False
        RequestSwitchesAndVariables()
    End Sub

#End Region

#Region "Move Route"
    Private Sub cmbEvent_Click(sender As Object, e As EventArgs) Handles cmbEvent.Click

    End Sub
    'MoveRoute Commands
    Private Sub lstvwMoveRoute_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstvwMoveRoute.Click
        If lstvwMoveRoute.SelectedItems.Count = 0 Then Exit Sub

        Select Case lstvwMoveRoute.SelectedItems(0).Index' + 1
            'Set Graphic
            Case 43
                fraGraphic.Width = 841
                fraGraphic.Height = 585
                fraGraphic.Visible = True
                GraphicSelType = 1
            Case Else
                AddMoveRouteCommand(lstvwMoveRoute.SelectedItems(0).Index)
        End Select
    End Sub

    Private Sub lstMoveRoute_KeyDown(sender As Object, e As KeyEventArgs) Handles lstMoveRoute.KeyDown
        If e.KeyCode = Keys.Delete Then
            'remove move route command lol
            If lstMoveRoute.SelectedIndex > -1 Then
                RemoveMoveRouteCommand(lstMoveRoute.SelectedIndex)
            End If
        End If
    End Sub

    Sub AddMoveRouteCommand(Index As Integer)
        Dim i As Long, X As Long

        Index = Index + 1
        If lstMoveRoute.SelectedIndex > -1 Then
            i = lstMoveRoute.SelectedIndex + 1
            TempMoveRouteCount = TempMoveRouteCount + 1
            ReDim Preserve TempMoveRoute(TempMoveRouteCount)
            For X = TempMoveRouteCount - 1 To i Step -1
                TempMoveRoute(X + 1) = TempMoveRoute(X)
            Next
            TempMoveRoute(i).Index = Index
            'if set graphic then...
            If Index = 43 Then
                TempMoveRoute(i).Data1 = cmbGraphic.SelectedIndex
                TempMoveRoute(i).Data2 = scrlGraphic.Value
                TempMoveRoute(i).Data3 = GraphicSelX
                TempMoveRoute(i).Data4 = GraphicSelX2
                TempMoveRoute(i).Data5 = GraphicSelY
                TempMoveRoute(i).Data6 = GraphicSelY2
            End If
            PopulateMoveRouteList()
        Else
            TempMoveRouteCount = TempMoveRouteCount + 1
            ReDim Preserve TempMoveRoute(TempMoveRouteCount)
            TempMoveRoute(TempMoveRouteCount).Index = Index
            PopulateMoveRouteList()
            'if set graphic then....
            If Index = 43 Then
                TempMoveRoute(TempMoveRouteCount).Data1 = cmbGraphic.SelectedIndex
                TempMoveRoute(TempMoveRouteCount).Data2 = scrlGraphic.Value
                TempMoveRoute(TempMoveRouteCount).Data3 = GraphicSelX
                TempMoveRoute(TempMoveRouteCount).Data4 = GraphicSelX2
                TempMoveRoute(TempMoveRouteCount).Data5 = GraphicSelY
                TempMoveRoute(TempMoveRouteCount).Data6 = GraphicSelY2
            End If
        End If

    End Sub

    Sub RemoveMoveRouteCommand(Index As Long)
        Dim i As Long

        Index = Index + 1
        If Index > 0 And Index <= TempMoveRouteCount Then
            For i = Index + 1 To TempMoveRouteCount
                TempMoveRoute(i - 1) = TempMoveRoute(i)
            Next
            TempMoveRouteCount = TempMoveRouteCount - 1
            If TempMoveRouteCount = 0 Then
                ReDim TempMoveRoute(0)
            Else
                ReDim Preserve TempMoveRoute(TempMoveRouteCount)
            End If
            PopulateMoveRouteList()
        End If

    End Sub

    Sub PopulateMoveRouteList()
        Dim i As Long

        lstMoveRoute.Items.Clear()

        For i = 1 To TempMoveRouteCount
            Select Case TempMoveRoute(i).Index
                Case 1
                    lstMoveRoute.Items.Add("Move Up")
                Case 2
                    lstMoveRoute.Items.Add("Move Down")
                Case 3
                    lstMoveRoute.Items.Add("Move Left")
                Case 4
                    lstMoveRoute.Items.Add("Move Right")
                Case 5
                    lstMoveRoute.Items.Add("Move Randomly")
                Case 6
                    lstMoveRoute.Items.Add("Move Towards Player")
                Case 7
                    lstMoveRoute.Items.Add("Move Away From Player")
                Case 8
                    lstMoveRoute.Items.Add("Step Forward")
                Case 9
                    lstMoveRoute.Items.Add("Step Back")
                Case 10
                    lstMoveRoute.Items.Add("Wait 100ms")
                Case 11
                    lstMoveRoute.Items.Add("Wait 500ms")
                Case 12
                    lstMoveRoute.Items.Add("Wait 1000ms")
                Case 13
                    lstMoveRoute.Items.Add("Turn Up")
                Case 14
                    lstMoveRoute.Items.Add("Turn Down")
                Case 15
                    lstMoveRoute.Items.Add("Turn Left")
                Case 16
                    lstMoveRoute.Items.Add("Turn Right")
                Case 17
                    lstMoveRoute.Items.Add("Turn 90 Degrees To the Right")
                Case 18
                    lstMoveRoute.Items.Add("Turn 90 Degrees To the Left")
                Case 19
                    lstMoveRoute.Items.Add("Turn Around 180 Degrees")
                Case 20
                    lstMoveRoute.Items.Add("Turn Randomly")
                Case 21
                    lstMoveRoute.Items.Add("Turn Towards Player")
                Case 22
                    lstMoveRoute.Items.Add("Turn Away from Player")
                Case 23
                    lstMoveRoute.Items.Add("Set Speed 8x Slower")
                Case 24
                    lstMoveRoute.Items.Add("Set Speed 4x Slower")
                Case 25
                    lstMoveRoute.Items.Add("Set Speed 2x Slower")
                Case 26
                    lstMoveRoute.Items.Add("Set Speed to Normal")
                Case 27
                    lstMoveRoute.Items.Add("Set Speed 2x Faster")
                Case 28
                    lstMoveRoute.Items.Add("Set Speed 4x Faster")
                Case 29
                    lstMoveRoute.Items.Add("Set Frequency Lowest")
                Case 30
                    lstMoveRoute.Items.Add("Set Frequency Lower")
                Case 31
                    lstMoveRoute.Items.Add("Set Frequency Normal")
                Case 32
                    lstMoveRoute.Items.Add("Set Frequency Higher")
                Case 33
                    lstMoveRoute.Items.Add("Set Frequency Highest")
                Case 34
                    lstMoveRoute.Items.Add("Turn On Walking Animation")
                Case 35
                    lstMoveRoute.Items.Add("Turn Off Walking Animation")
                Case 36
                    lstMoveRoute.Items.Add("Turn On Fixed Direction")
                Case 37
                    lstMoveRoute.Items.Add("Turn Off Fixed Direction")
                Case 38
                    lstMoveRoute.Items.Add("Turn On Walk Through")
                Case 39
                    lstMoveRoute.Items.Add("Turn Off Walk Through")
                Case 40
                    lstMoveRoute.Items.Add("Set Position Below Player")
                Case 41
                    lstMoveRoute.Items.Add("Set Position at Player Level")
                Case 42
                    lstMoveRoute.Items.Add("Set Position Above Player")
                Case 43
                    lstMoveRoute.Items.Add("Set Graphic")
            End Select
        Next

    End Sub

    Private Sub chkIgnoreMove_CheckedChanged(sender As Object, e As EventArgs) Handles chkIgnoreMove.CheckedChanged
        If chkIgnoreMove.Checked = True Then
            tmpEvent.Pages(curPageNum).IgnoreMoveRoute = 1
        Else
            tmpEvent.Pages(curPageNum).IgnoreMoveRoute = 0
        End If
    End Sub

    Private Sub chkRepeatRoute_CheckedChanged(sender As Object, e As EventArgs) Handles chkRepeatRoute.CheckedChanged
        If chkRepeatRoute.Checked = True Then
            tmpEvent.Pages(curPageNum).RepeatMoveRoute = 1
        Else
            tmpEvent.Pages(curPageNum).RepeatMoveRoute = 0
        End If
    End Sub

    Private Sub btnMoveRouteOk_Click(sender As Object, e As EventArgs) Handles btnMoveRouteOk.Click
        If IsMoveRouteCommand = True Then
            If Not isEdit Then
                AddCommand(EventType.evSetMoveRoute)
            Else
                EditCommand()
            End If
            TempMoveRouteCount = 0
            ReDim TempMoveRoute(0)
            pnlMoveRoute.Visible = False
        Else
            tmpEvent.Pages(curPageNum).MoveRouteCount = TempMoveRouteCount
            tmpEvent.Pages(curPageNum).MoveRoute = TempMoveRoute
            TempMoveRouteCount = 0
            ReDim TempMoveRoute(0)
            pnlMoveRoute.Visible = False
        End If
    End Sub

    Private Sub btnMoveRouteCancel_Click(sender As Object, e As EventArgs) Handles btnMoveRouteCancel.Click
        TempMoveRouteCount = 0
        ReDim TempMoveRoute(0)
        pnlMoveRoute.Visible = False
    End Sub




#End Region

#Region "CommandFrames"
#Region "Show Text"
    Private Sub scrlShowTextFace_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlShowTextFace.Scroll
        If scrlShowTextFace.Value > 0 Then
            lblShowTextFace.Text = "Face: " & scrlShowTextFace.Value
            If FileExist(Application.StartupPath & GFX_PATH & "Faces\" & scrlShowTextFace.Value & GFX_EXT) Then
                picShowTextFace.BackgroundImage = Drawing.Image.FromFile(Application.StartupPath & GFX_PATH & "Faces\" & scrlShowTextFace.Value & GFX_EXT)
            End If
        Else
            lblShowTextFace.Text = "Face: None"
            picShowTextFace.BackgroundImage = Nothing
        End If
    End Sub

    Private Sub btnShowTextOk_Click(sender As Object, e As EventArgs) Handles btnShowTextOk.Click
        If Not isEdit Then
            AddCommand(EventType.evShowText)
        Else
            EditCommand()
        End If

        ' hide
        fraDialogue.Visible = False
        fraShowText.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnShowTextCancel_Click(sender As Object, e As EventArgs) Handles btnShowTextCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraShowText.Visible = False
    End Sub
#End Region

#Region "Add Text"
    Private Sub txtAddText_Text_TextChanged(sender As Object, e As EventArgs) Handles txtAddText_Text.TextChanged

    End Sub

    Private Sub optAddText_Player_CheckedChanged(sender As Object, e As EventArgs) Handles optAddText_Player.CheckedChanged

    End Sub

    Private Sub optAddText_Map_CheckedChanged(sender As Object, e As EventArgs) Handles optAddText_Map.CheckedChanged

    End Sub

    Private Sub optAddText_Global_CheckedChanged(sender As Object, e As EventArgs) Handles optAddText_Global.CheckedChanged

    End Sub

    Private Sub btnAddTextOk_Click(sender As Object, e As EventArgs) Handles btnAddTextOk.Click
        If Not isEdit Then
            AddCommand(EventType.evAddText)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraAddText.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnAddTextCancel_Click(sender As Object, e As EventArgs) Handles btnAddTextCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraAddText.Visible = False
    End Sub
#End Region

#Region "show choices"
    Private Sub scrlShowChoicesFace_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlShowChoicesFace.Scroll
        If scrlShowChoicesFace.Value > 0 Then
            lblShowChoicesFace.Text = "Face: " & scrlShowChoicesFace.Value
            If FileExist(Application.StartupPath & GFX_PATH & "Faces\" & scrlShowChoicesFace.Value & GFX_EXT) Then
                picShowChoicesFace.BackgroundImage = Drawing.Image.FromFile(Application.StartupPath & GFX_PATH & "Faces\" & scrlShowChoicesFace.Value & GFX_EXT)
            End If
        Else
            picShowChoicesFace.Text = "Face: None"
            picShowChoicesFace.BackgroundImage = Nothing
        End If
    End Sub

    Private Sub btnShowChoicesOk_Click(sender As Object, e As EventArgs) Handles btnShowChoicesOk.Click
        If Not isEdit Then
            AddCommand(EventType.evShowChoices)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraShowChoices.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnShowChoicesCancel_Click(sender As Object, e As EventArgs) Handles btnShowChoicesCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraShowChoices.Visible = False
    End Sub
#End Region

#Region "Show Chatbubble"
    Private Sub optChatBubbleTarget0_CheckedChanged(sender As Object, e As EventArgs) Handles optChatBubbleTarget0.CheckedChanged
        cmbChatBubbleTarget.Visible = False
    End Sub

    Private Sub optChatBubbleTarget1_CheckedChanged(sender As Object, e As EventArgs) Handles optChatBubbleTarget1.CheckedChanged
        cmbChatBubbleTarget.Visible = True
        cmbChatBubbleTarget.Items.Clear()

        For i = 1 To MAX_MAP_NPCS
            If Map.Npc(i) <= 0 Then
                cmbChatBubbleTarget.Items.Add(CStr(i) & ". ")
            Else
                cmbChatBubbleTarget.Items.Add(CStr(i) & ". " & Trim$(Npc(Map.Npc(i)).Name))
            End If
        Next
        cmbChatBubbleTarget.SelectedIndex = 0
    End Sub

    Private Sub optChatBubbleTarget2_CheckedChanged(sender As Object, e As EventArgs) Handles optChatBubbleTarget2.CheckedChanged
        cmbChatBubbleTarget.Visible = True
        cmbChatBubbleTarget.Items.Clear()

        For i = 1 To Map.EventCount
            cmbChatBubbleTarget.Items.Add(CStr(i) & ". " & Trim$(Map.Events(i).Name))
        Next
        cmbChatBubbleTarget.SelectedIndex = 0
    End Sub

    Private Sub btnShowChatBubbleOK_Click(sender As Object, e As EventArgs) Handles btnShowChatBubbleOK.Click
        If Not isEdit Then
            AddCommand(EventType.evShowChatBubble)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraShowChatBubble.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnShowChatBubbleCancel_Click(sender As Object, e As EventArgs) Handles btnShowChatBubbleCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraShowChatBubble.Visible = False
    End Sub
#End Region

#Region "Set Player Variable"
    Private Sub cmbVariable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVariable.SelectedIndexChanged

    End Sub

    Private Sub optVariableAction0_CheckedChanged(sender As Object, e As EventArgs) Handles optVariableAction0.CheckedChanged
        If optVariableAction0.Checked = True Then
            txtVariableData0.Enabled = True
            txtVariableData0.Text = "0"
            txtVariableData1.Enabled = False
            txtVariableData1.Text = "0"
            txtVariableData2.Enabled = False
            txtVariableData2.Text = "0"
            txtVariableData3.Enabled = False
            txtVariableData3.Text = "0"
            txtVariableData4.Enabled = False
            txtVariableData4.Text = "0"
        End If
    End Sub

    Private Sub optVariableAction1_CheckedChanged(sender As Object, e As EventArgs) Handles optVariableAction1.CheckedChanged
        If optVariableAction1.Checked = True Then
            txtVariableData0.Enabled = False
            txtVariableData0.Text = "0"
            txtVariableData1.Enabled = True
            txtVariableData1.Text = "0"
            txtVariableData2.Enabled = False
            txtVariableData2.Text = "0"
            txtVariableData3.Enabled = False
            txtVariableData3.Text = "0"
            txtVariableData4.Enabled = False
            txtVariableData4.Text = "0"
        End If
    End Sub

    Private Sub optVariableAction2_CheckedChanged(sender As Object, e As EventArgs) Handles optVariableAction2.CheckedChanged
        If optVariableAction2.Checked = True Then
            txtVariableData0.Enabled = False
            txtVariableData0.Text = "0"
            txtVariableData1.Enabled = False
            txtVariableData1.Text = "0"
            txtVariableData2.Enabled = True
            txtVariableData2.Text = "0"
            txtVariableData3.Enabled = False
            txtVariableData3.Text = "0"
            txtVariableData4.Enabled = False
            txtVariableData4.Text = "0"
        End If
    End Sub

    Private Sub optVariableAction3_CheckedChanged(sender As Object, e As EventArgs) Handles optVariableAction3.CheckedChanged
        If optVariableAction2.Checked = True Then
            txtVariableData0.Enabled = False
            txtVariableData0.Text = "0"
            txtVariableData1.Enabled = False
            txtVariableData1.Text = "0"
            txtVariableData2.Enabled = False
            txtVariableData2.Text = "0"
            txtVariableData3.Enabled = True
            txtVariableData3.Text = "0"
            txtVariableData4.Enabled = True
            txtVariableData4.Text = "0"
        End If
    End Sub

    Private Sub btnPlayerVarOk_Click(sender As Object, e As EventArgs) Handles btnPlayerVarOk.Click
        If Not isEdit Then
            AddCommand(EventType.evPlayerVar)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraPlayerVariable.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnPlayerVarCancel_Click(sender As Object, e As EventArgs) Handles btnPlayerVarCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraPlayerVariable.Visible = False
    End Sub
#End Region

#Region "Set Player Switch"
    Private Sub cmbSwitch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSwitch.SelectedIndexChanged

    End Sub

    Private Sub cmbPlayerSwitchSet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlayerSwitchSet.SelectedIndexChanged

    End Sub

    Private Sub btnSetPlayerSwitchOk_Click(sender As Object, e As EventArgs) Handles btnSetPlayerSwitchOk.Click
        If Not isEdit Then
            AddCommand(EventType.evPlayerSwitch)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraPlayerSwitch.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnSetPlayerswitchCancel_Click(sender As Object, e As EventArgs) Handles btnSetPlayerswitchCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraPlayerSwitch.Visible = False
    End Sub

#End Region

#Region "Set Self Switch"
    Private Sub cmbSetSelfSwitch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSetSelfSwitch.SelectedIndexChanged

    End Sub

    Private Sub cmbSetSelfSwitchTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSetSelfSwitchTo.SelectedIndexChanged

    End Sub

    Private Sub btnSelfswitchOk_Click(sender As Object, e As EventArgs) Handles btnSelfswitchOk.Click
        If Not isEdit Then
            AddCommand(EventType.evSelfSwitch)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraSetSelfSwitch.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnSelfswitchCancel_Click(sender As Object, e As EventArgs) Handles btnSelfswitchCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraSetSelfSwitch.Visible = False
    End Sub
#End Region

#Region "Conditional Branch"
    Private Sub optCondition_Index0_CheckedChanged(sender As Object, e As EventArgs) Handles optCondition0.CheckedChanged
        If Not optCondition0.Checked Then Exit Sub

        ClearConditionFrame()

        cmbCondition_PlayerVarIndex.Enabled = True
        cmbCondition_PlayerVarCompare.Enabled = True
        txtCondition_PlayerVarCondition.Enabled = True
    End Sub

    Private Sub optCondition1_CheckedChanged(sender As Object, e As EventArgs) Handles optCondition1.CheckedChanged
        If Not optCondition1.Checked Then Exit Sub

        ClearConditionFrame()

        cmbCondition_PlayerSwitch.Enabled = True
        cmbCondtion_PlayerSwitchCondition.Enabled = True
    End Sub

    Private Sub optCondition2_CheckedChanged(sender As Object, e As EventArgs) Handles optCondition2.CheckedChanged
        If Not optCondition2.Checked Then Exit Sub

        ClearConditionFrame()

        cmbCondition_HasItem.Enabled = True
        scrlCondition_HasItem.Enabled = True
    End Sub

    Private Sub optCondition3_CheckedChanged(sender As Object, e As EventArgs) Handles optCondition3.CheckedChanged
        If Not optCondition3.Checked Then Exit Sub

        ClearConditionFrame()

        cmbCondition_ClassIs.Enabled = True
    End Sub

    Private Sub optCondition4_CheckedChanged(sender As Object, e As EventArgs) Handles optCondition4.CheckedChanged
        If Not optCondition4.Checked Then Exit Sub

        cmbCondition_LearntSkill.Enabled = True
    End Sub

    Private Sub optCondition5_CheckedChanged(sender As Object, e As EventArgs) Handles optCondition5.CheckedChanged
        If Not optCondition5.Checked Then Exit Sub

        ClearConditionFrame()

        cmbCondition_LevelCompare.Enabled = True
        txtCondition_LevelAmount.Enabled = True
    End Sub

    Private Sub optCondition6_CheckedChanged(sender As Object, e As EventArgs) Handles optCondition6.CheckedChanged
        If Not optCondition6.Checked Then Exit Sub

        ClearConditionFrame()

        cmbCondition_SelfSwitch.Enabled = True
        cmbCondition_SelfSwitchCondition.Enabled = True
    End Sub

    Private Sub optCondition7_CheckedChanged(sender As Object, e As EventArgs) Handles optCondition7.CheckedChanged
        If Not optCondition7.Checked Then Exit Sub

        ClearConditionFrame()

        fraConditions_Quest.Visible = True
        scrlCondition_Quest.Enabled = True
    End Sub

    Private Sub optCondition8_CheckedChanged(sender As Object, e As EventArgs) Handles optCondition8.CheckedChanged
        If Not optCondition8.Checked Then Exit Sub

        ClearConditionFrame()

        cmbCondition_Gender.Enabled = True
    End Sub

    Private Sub scrlCondition_HasItem_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlCondition_HasItem.Scroll
        lblHasItemAmt.Text = "x " & scrlCondition_HasItem.Value
    End Sub

    Private Sub scrlCondition_Quest_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlCondition_Quest.Scroll
        lblCondition_QuestTask.Text = "#" & scrlCondition_QuestTask.Value
    End Sub

    Private Sub scrlCondition_QuestTask_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlCondition_QuestTask.Scroll
        lblCondition_QuestTask.Text = "#" & scrlCondition_QuestTask.Value
    End Sub

    Private Sub btnConditionalBranchOk_Click(sender As Object, e As EventArgs) Handles btnConditionalBranchOk.Click
        If isEdit = False Then
            AddCommand(EventType.evCondition)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraCommands.Visible = False
        fraConditionalBranch.Visible = False
    End Sub

    Private Sub btnConditionalBranchCancel_Click(sender As Object, e As EventArgs) Handles btnConditionalBranchCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraConditionalBranch.Visible = False
    End Sub

#End Region

#Region "Create Label"
    Private Sub txtLabelName_TextChanged(sender As Object, e As EventArgs) Handles txtLabelName.TextChanged

    End Sub

    Private Sub btnCreatelabelOk_Click(sender As Object, e As EventArgs) Handles btnCreatelabelOk.Click
        If isEdit = False Then
            AddCommand(EventType.evLabel)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraCreateLabel.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnCreateLabelCancel_Click(sender As Object, e As EventArgs) Handles btnCreateLabelCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraCreateLabel.Visible = False
    End Sub

#End Region

#Region "GoTo Label"
    Private Sub txtGotoLabel_TextChanged(sender As Object, e As EventArgs) Handles txtGotoLabel.TextChanged

    End Sub

    Private Sub btnGoToLabelOk_Click(sender As Object, e As EventArgs) Handles btnGoToLabelOk.Click
        If isEdit = False Then
            AddCommand(EventType.evGotoLabel)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraGoToLabel.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnGoToLabelCancel_Click(sender As Object, e As EventArgs) Handles btnGoToLabelCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraGoToLabel.Visible = False
    End Sub

#End Region

#Region "Change Items"
    Private Sub optChangeItemSet_CheckedChanged(sender As Object, e As EventArgs) Handles optChangeItemSet.CheckedChanged

    End Sub

    Private Sub optChangeItemAdd_CheckedChanged(sender As Object, e As EventArgs) Handles optChangeItemAdd.CheckedChanged

    End Sub

    Private Sub optChangeItemRemove_CheckedChanged(sender As Object, e As EventArgs) Handles optChangeItemRemove.CheckedChanged

    End Sub

    Private Sub txtChangeItemsAmount_TextChanged(sender As Object, e As EventArgs) Handles txtChangeItemsAmount.TextChanged

    End Sub

    Private Sub btnChangeItemsOk_Click(sender As Object, e As EventArgs) Handles btnChangeItemsOk.Click
        If isEdit = False Then
            AddCommand(EventType.evChangeItems)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraCommands.Visible = False
        fraChangeItems.Visible = False
    End Sub

    Private Sub btnChangeItemsCancel_Click(sender As Object, e As EventArgs) Handles btnChangeItemsCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraChangeItems.Visible = False
    End Sub

    Private Sub cmbChangeItemIndex_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbChangeItemIndex.SelectedIndexChanged
        tmpEvent.Pages(curPageNum).Questnum = cmbEventQuest.SelectedIndex
    End Sub

#End Region

#Region "Change Level"
    Private Sub scrlChangeLevel_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlChangeLevel.Scroll
        lblChangeLevel.Text = "Level: " & scrlChangeLevel.Value
    End Sub

    Private Sub btnChangeLevelOK_Click(sender As Object, e As EventArgs) Handles btnChangeLevelOK.Click
        If isEdit = False Then
            AddCommand(EventType.evChangeLevel)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraChangeLevel.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnChangeLevelCancel_Click(sender As Object, e As EventArgs) Handles btnChangeLevelCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraChangeLevel.Visible = False
    End Sub

#End Region

#Region "Change Skills"
    Private Sub cmbChangeSkills_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbChangeSkills.SelectedIndexChanged

    End Sub

    Private Sub optChangeSkillsAdd_CheckedChanged(sender As Object, e As EventArgs) Handles optChangeSkillsAdd.CheckedChanged

    End Sub

    Private Sub optChangeSkillsRemove_CheckedChanged(sender As Object, e As EventArgs) Handles optChangeSkillsRemove.CheckedChanged

    End Sub

    Private Sub btnChangeSkillsOK_Click(sender As Object, e As EventArgs) Handles btnChangeSkillsOK.Click
        If isEdit = False Then
            AddCommand(EventType.evChangeSkills)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraChangeSkills.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnChangeSkillsCancel_Click(sender As Object, e As EventArgs) Handles btnChangeSkillsCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraChangeSkills.Visible = False
    End Sub



#End Region

#Region "Change Class"
    Private Sub cmbChangeClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbChangeClass.SelectedIndexChanged

    End Sub

    Private Sub btnChangeClassOK_Click(sender As Object, e As EventArgs) Handles btnChangeClassOK.Click
        If isEdit = False Then
            AddCommand(EventType.evChangeClass)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraChangeClass.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnChangeClassCancel_Click(sender As Object, e As EventArgs) Handles btnChangeClassCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraChangeClass.Visible = False
    End Sub


#End Region

#Region "Change Sprite"
    Private Sub scrlChangeSprite_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlChangeSprite.Scroll
        lblChangeSprite.Text = "Sprite: " & scrlChangeSprite.Value
    End Sub

    Private Sub btnChangeSpriteOK_Click(sender As Object, e As EventArgs) Handles btnChangeSpriteOK.Click
        If isEdit = False Then
            AddCommand(EventType.evChangeSprite)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraChangeSprite.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnChangeSpriteCancel_Click(sender As Object, e As EventArgs) Handles btnChangeSpriteCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraChangeSprite.Visible = False
    End Sub

#End Region

#Region "Change Gender"
    Private Sub optChangeSexMale_CheckedChanged(sender As Object, e As EventArgs) Handles optChangeSexMale.CheckedChanged

    End Sub

    Private Sub optChangeSexFemale_CheckedChanged(sender As Object, e As EventArgs) Handles optChangeSexFemale.CheckedChanged

    End Sub

    Private Sub btnChangeGenderOK_Click(sender As Object, e As EventArgs) Handles btnChangeGenderOK.Click
        If isEdit = False Then
            AddCommand(EventType.evChangeSex)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraChangeGender.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnChangeGenderCancel_Click(sender As Object, e As EventArgs) Handles btnChangeGenderCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraChangeGender.Visible = False
    End Sub

#End Region

#Region "Change PK"
    Private Sub optChangePKYes_CheckedChanged(sender As Object, e As EventArgs) Handles optChangePKYes.CheckedChanged

    End Sub

    Private Sub optChangePKNo_CheckedChanged(sender As Object, e As EventArgs) Handles optChangePKNo.CheckedChanged

    End Sub

    Private Sub btnChangePkOK_Click(sender As Object, e As EventArgs) Handles btnChangePkOK.Click
        If isEdit = False Then
            AddCommand(EventType.evChangePK)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraChangePK.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnChangePkCancel_Click(sender As Object, e As EventArgs) Handles btnChangePkCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraChangePK.Visible = False
    End Sub

#End Region

#Region "Give Exp"
    Private Sub scrlGiveExp_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlGiveExp.Scroll
        lblGiveExp.Text = "Give Exp: " & scrlGiveExp.Value
    End Sub

    Private Sub btnGiveExpOK_Click(sender As Object, e As EventArgs) Handles btnGiveExpOK.Click
        If isEdit = False Then
            AddCommand(EventType.evGiveExp)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraGiveExp.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnGiveExpCancel_Click(sender As Object, e As EventArgs) Handles btnGiveExpCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraGiveExp.Visible = False
    End Sub

#End Region

#Region "Player Warp"
    Private Sub scrlWPMap_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlWPMap.Scroll
        lblWPMap.Text = "Map: " & scrlWPMap.Value
    End Sub

    Private Sub scrlWPX_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlWPX.Scroll
        lblWPX.Text = "X: " & scrlWPX.Value
    End Sub

    Private Sub scrlWPY_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlWPY.Scroll
        lblWPY.Text = "Y: " & scrlWPY.Value
    End Sub

    Private Sub cmbWarpPlayerDir_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbWarpPlayerDir.SelectedIndexChanged

    End Sub

    Private Sub btnPlayerWarpOK_Click(sender As Object, e As EventArgs) Handles btnPlayerWarpOK.Click
        If Not isEdit Then
            AddCommand(EventType.evWarpPlayer)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraPlayerWarp.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnPlayerWarpCancel_Click(sender As Object, e As EventArgs) Handles btnPlayerWarpCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraPlayerWarp.Visible = False
    End Sub


#End Region

#Region "Route Completion"
    Private Sub cmbMoveWait_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMoveWait.SelectedIndexChanged

    End Sub

    Private Sub btnMoveWaitOK_Click(sender As Object, e As EventArgs) Handles btnMoveWaitOK.Click
        If Not isEdit Then
            AddCommand(EventType.evWaitMovement)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraMoveRouteWait.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnMoveWaitCancel_Click(sender As Object, e As EventArgs) Handles btnMoveWaitCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraMoveRouteWait.Visible = False
    End Sub

#End Region

#Region "Spawn Npc"
    Private Sub cmbSpawnNPC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSpawnNPC.SelectedIndexChanged

    End Sub

    Private Sub btnSpawnNpcOK_Click(sender As Object, e As EventArgs) Handles btnSpawnNpcOK.Click
        If isEdit = False Then
            AddCommand(EventType.evSpawnNpc)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraSpawnNpc.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnSpawnNpcCancel_Click(sender As Object, e As EventArgs) Handles btnSpawnNpcCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraSpawnNpc.Visible = False
    End Sub

#End Region

#Region "Play Animation"
    Private Sub cmbPlayAnim_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlayAnim.SelectedIndexChanged

    End Sub

    Private Sub optPlayAnimPlayer_CheckedChanged(sender As Object, e As EventArgs) Handles optPlayAnimPlayer.CheckedChanged
        lblPlayAnimX.Visible = False
        lblPlayAnimY.Visible = False
        scrlPlayAnimTileX.Visible = False
        scrlPlayAnimTileY.Visible = False
        cmbPlayAnimEvent.Visible = False
    End Sub

    Private Sub optPlayAnimEvent_CheckedChanged(sender As Object, e As EventArgs) Handles optPlayAnimEvent.CheckedChanged
        lblPlayAnimX.Visible = False
        lblPlayAnimY.Visible = False
        scrlPlayAnimTileX.Visible = False
        scrlPlayAnimTileY.Visible = False
        cmbPlayAnimEvent.Visible = True
    End Sub

    Private Sub optPlayAnimTile_CheckedChanged(sender As Object, e As EventArgs) Handles optPlayAnimTile.CheckedChanged
        lblPlayAnimX.Visible = True
        lblPlayAnimY.Visible = True
        scrlPlayAnimTileX.Visible = True
        scrlPlayAnimTileY.Visible = True
        cmbPlayAnimEvent.Visible = False
    End Sub

    Private Sub cmbPlayAnimEvent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlayAnimEvent.SelectedIndexChanged

    End Sub

    Private Sub scrlPlayAnimTileX_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlPlayAnimTileX.Scroll
        lblPlayAnimX.Text = "Map Tile X: " & scrlPlayAnimTileX.Value
    End Sub

    Private Sub scrlPlayAnimTileY_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlPlayAnimTileY.Scroll
        lblPlayAnimY.Text = "Map Tile Y: " & scrlPlayAnimTileY.Value
    End Sub

    Private Sub btnPlayAnimationOK_Click(sender As Object, e As EventArgs) Handles btnPlayAnimationOK.Click
        If Not isEdit Then
            AddCommand(EventType.evPlayAnimation)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraPlayAnimation.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnPlayAnimationCancel_Click(sender As Object, e As EventArgs) Handles btnPlayAnimationCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraPlayAnimation.Visible = False
    End Sub

#End Region

#Region "Begin Quest"
    Private Sub cmbBeginQuest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBeginQuest.SelectedIndexChanged

    End Sub

    Private Sub btnBeginQuestOK_Click(sender As Object, e As EventArgs) Handles btnBeginQuestOK.Click
        If Not isEdit Then
            AddCommand(EventType.evBeginQuest)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraBeginQuest.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnBeginQuestCancel_Click(sender As Object, e As EventArgs) Handles btnBeginQuestCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraBeginQuest.Visible = False
    End Sub


#End Region

#Region "Complete QuestTask"
    Private Sub scrlCompleteQuestTaskQuest_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlCompleteQuestTaskQuest.Scroll
        lblRandomLabel47.Text = "Quest: " & scrlCompleteQuestTaskQuest.Value & "."
    End Sub

    Private Sub scrlCompleteQuestTask_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlCompleteQuestTask.Scroll
        lblRandomLabel48.Text = "Task: " & scrlCompleteQuestTask.Value & "."
    End Sub

    Private Sub btnCompleteQuestTaskOK_Click(sender As Object, e As EventArgs) Handles btnCompleteQuestTaskOK.Click
        If Not isEdit Then
            AddCommand(EventType.evQuestTask)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraCompleteTask.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnCompleteQuestTaskCancel_Click(sender As Object, e As EventArgs) Handles btnCompleteQuestTaskCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraCompleteTask.Visible = False
    End Sub

#End Region

#Region "End Quest"
    Private Sub cmbEndQuest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEndQuest.SelectedIndexChanged

    End Sub

    Private Sub btnEndQuestOK_Click(sender As Object, e As EventArgs) Handles btnEndQuestOK.Click
        If Not isEdit Then
            AddCommand(EventType.evEndQuest)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraEndQuest.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnEndQuestCancel_Click(sender As Object, e As EventArgs) Handles btnEndQuestCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraEndQuest.Visible = False
    End Sub

#End Region

#Region "Set Fog"
    Private Sub ScrlFogData0_Scroll(sender As Object, e As ScrollEventArgs) Handles ScrlFogData0.Scroll
        If ScrlFogData0.Value = 0 Then
            lblFogData0.Text = "None."
        Else
            lblFogData0.Text = "Fog: " & ScrlFogData0.Value
        End If
    End Sub

    Private Sub ScrlFogData1_Scroll(sender As Object, e As ScrollEventArgs) Handles ScrlFogData1.Scroll
        lblFogData1.Text = "Fog Speed: " & ScrlFogData1.Value
    End Sub

    Private Sub ScrlFogData2_Scroll(sender As Object, e As ScrollEventArgs) Handles ScrlFogData2.Scroll
        lblFogData2.Text = "Fog Opacity: " & ScrlFogData2.Value
    End Sub

    Private Sub btnSetFogOK_Click(sender As Object, e As EventArgs) Handles btnSetFogOK.Click
        If Not isEdit Then
            AddCommand(EventType.evSetFog)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraSetFog.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnSetFogCancel_Click(sender As Object, e As EventArgs) Handles btnSetFogCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraSetFog.Visible = False
    End Sub

#End Region

#Region "Set Weather"
    Private Sub CmbWeather_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbWeather.SelectedIndexChanged

    End Sub

    Private Sub scrlWeatherIntensity_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlWeatherIntensity.Scroll
        lblWeatherIntensity.Text = "Intensity: " & scrlWeatherIntensity.Value
    End Sub

    Private Sub btnSetWeatherOK_Click(sender As Object, e As EventArgs) Handles btnSetWeatherOK.Click
        If Not isEdit Then
            AddCommand(EventType.evSetWeather)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraSetWeather.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnSetWeatherCancel_Click(sender As Object, e As EventArgs) Handles btnSetWeatherCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraSetWeather.Visible = False
    End Sub

#End Region

#Region "Set Map Tint"
    Private Sub scrlMapTintData0_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlMapTintData0.Scroll
        lblMapTintData0.Text = "Red: " & scrlMapTintData0.Value
    End Sub

    Private Sub scrlMapTintData1_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlMapTintData1.Scroll
        lblMapTintData1.Text = "Green: " & scrlMapTintData1.Value
    End Sub

    Private Sub scrlMapTintData2_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlMapTintData2.Scroll
        lblMapTintData2.Text = "Blue: " & scrlMapTintData2.Value
    End Sub

    Private Sub scrlMapTintData3_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlMapTintData3.Scroll
        lblMapTintData3.Text = "Opacity: " & scrlMapTintData3.Value
    End Sub

    Private Sub btnMapTintOK_Click(sender As Object, e As EventArgs) Handles btnMapTintOK.Click
        If Not isEdit Then
            AddCommand(EventType.evSetTint)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraMapTint.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnMapTintCancel_Click(sender As Object, e As EventArgs) Handles btnMapTintCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraMapTint.Visible = False
    End Sub

#End Region

#Region "Play BGM"
    Private Sub cmbPlayBGM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlayBGM.SelectedIndexChanged

    End Sub

    Private Sub btnPlayBgmOK_Click(sender As Object, e As EventArgs) Handles btnPlayBgmOK.Click
        If Not isEdit Then
            AddCommand(EventType.evPlayBGM)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraPlayBGM.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnPlayBgmCancel_Click(sender As Object, e As EventArgs) Handles btnPlayBgmCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraPlayBGM.Visible = False
    End Sub

#End Region

#Region "Play Sound"
    Private Sub cmbPlaySound_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlaySound.SelectedIndexChanged

    End Sub

    Private Sub btnPlaySoundOK_Click(sender As Object, e As EventArgs) Handles btnPlaySoundOK.Click
        If Not isEdit Then
            AddCommand(EventType.evPlaySound)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraPlaySound.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnPlaySoundCancel_Click(sender As Object, e As EventArgs) Handles btnPlaySoundCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraPlaySound.Visible = False
    End Sub

#End Region

#Region "Wait"
    Private Sub scrlWaitAmount_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlWaitAmount.Scroll
        lblWaitAmount.Text = "Wait: " & scrlWaitAmount.Value & " Ms"
    End Sub

    Private Sub btnSetWaitOK_Click(sender As Object, e As EventArgs) Handles btnSetWaitOK.Click
        If Not isEdit Then
            AddCommand(EventType.evWait)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraSetWait.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnSetWaitCancel_Click(sender As Object, e As EventArgs) Handles btnSetWaitCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraSetWait.Visible = False
    End Sub

#End Region

#Region "Set Access"
    Private Sub cmbSetAccess_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSetAccess.SelectedIndexChanged

    End Sub

    Private Sub btnSetAccessOK_Click(sender As Object, e As EventArgs) Handles btnSetAccessOK.Click
        If Not isEdit Then
            AddCommand(EventType.evSetAccess)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraSetAccess.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnSetAccessCancel_Click(sender As Object, e As EventArgs) Handles btnSetAccessCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraSetAccess.Visible = False
    End Sub

#End Region

#Region "Custom Script"
    Private Sub scrlCustomScript_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlCustomScript.Scroll
        lblCustomScript.Text = "Case: " & scrlCustomScript.Value
    End Sub

    Private Sub btnCustomScriptOK_Click(sender As Object, e As EventArgs) Handles btnCustomScriptOK.Click
        If Not isEdit Then
            AddCommand(EventType.evCustomScript)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraCustomScript.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnCustomScriptCancel_Click(sender As Object, e As EventArgs) Handles btnCustomScriptCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraCustomScript.Visible = False
    End Sub

#End Region

#Region "Show Pic"
    Private Sub cmbPicIndex_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPicIndex.SelectedIndexChanged

    End Sub

    Private Sub scrlShowPicture_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlShowPicture.Scroll
        lblShowPic.Text = "Picture: " & scrlShowPicture.Value
    End Sub

    Private Sub optPic1_CheckedChanged(sender As Object, e As EventArgs) Handles optPic1.CheckedChanged

    End Sub

    Private Sub optPic2_CheckedChanged(sender As Object, e As EventArgs) Handles optPic2.CheckedChanged

    End Sub

    Private Sub optPic3_CheckedChanged(sender As Object, e As EventArgs) Handles optPic3.CheckedChanged

    End Sub

    Private Sub btnShowPicOK_Click(sender As Object, e As EventArgs) Handles btnShowPicOK.Click
        'Need to do some checks
        If Not IsNumeric(txtPicOffset1.Text) Then
            MsgBox("You must enter a valid number for the  x offset of the picture!")
            txtPicOffset1.Focus()
            Exit Sub
        End If
        If Not IsNumeric(txtPicOffset2.Text) Then
            MsgBox("You must enter a valid number for the  y offset of the picture!")
            txtPicOffset2.Focus()
            Exit Sub
        End If
        If Not isEdit Then
            AddCommand(EventType.evShowPicture)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraShowPic.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnShowPicCancel_Click(sender As Object, e As EventArgs) Handles btnShowPicCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraShowPic.Visible = False
    End Sub

#End Region

#Region "Hide Pic"
    Private Sub cmbHidePic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHidePic.SelectedIndexChanged

    End Sub

    Private Sub btnHidePicOK_Click(sender As Object, e As EventArgs) Handles btnHidePicOK.Click
        If Not isEdit Then
            AddCommand(EventType.evHidePicture)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraHidePic.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnHidePicCancel_Click(sender As Object, e As EventArgs) Handles btnHidePicCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraHidePic.Visible = False
    End Sub

#End Region

#Region "Open Shop"
    Private Sub cmbOpenShop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOpenShop.SelectedIndexChanged

    End Sub

    Private Sub btnOpenShopOK_Click(sender As Object, e As EventArgs) Handles btnOpenShopOK.Click
        If Not isEdit Then
            AddCommand(EventType.evOpenShop)
        Else
            EditCommand()
        End If
        ' hide
        fraDialogue.Visible = False
        fraOpenShop.Visible = False
        fraCommands.Visible = False
    End Sub

    Private Sub btnOpenShopCancel_Click(sender As Object, e As EventArgs) Handles btnOpenShopCancel.Click
        If Not isEdit Then fraCommands.Visible = True Else fraCommands.Visible = False
        fraDialogue.Visible = False
        fraOpenShop.Visible = False
    End Sub

#End Region

#End Region

End Class