Telltale Lua Scripting Documentation

# A

### *boolean* AppleControllerIsConnected()
- Returns a boolean

### *void* AppleGameControllerSetConnectedCallback(*string*)
- *string*: 1st Parameter
- Returns nothing

### *void* AppleGameControllerSetDisconnectedCallback(*string*)
- *string*: 1st Parameter
- Returns nothing

### *void* ActivateSystemHUD()
- Returns nothing

### *void* AgentSetWalkAnimatorPrevPos(*AgentObject*, *Vector3*)
- *AgentObject*: 1st Parameter
- *Vector3*: 2nd Parameter
- Returns nothing

### *boolean* AgentBGMTransitioning(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a boolean

### *boolean* AgentBGMActive(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a boolean

### *PlaybackController* AgentTransitionBGM(*AgentObject*, *Chore*, *Chore*, *number*, *BlendGraphManager*, *boolean*, *Vector3*)
- *AgentObject*: 1st Parameter
- *Chore*: 2nd Parameter
- *Chore*: 3rd Parameter
- *number*: 4th Parameter
- *BlendGraphManager*: 5th Parameter
- *boolean*: 6th Parameter
- *Vector3*: 7th Parameter
- Returns a PlaybackController

### *void* AgentSetBGMTransitionTarget(*AgentObject*, *Vector3*)
- *AgentObject*: 1st Parameter
- *Vector3*: 2nd Parameter
- Returns nothing

### *void* AgentSetRunning(*AgentObject*, *boolean*)
- *AgentObject*: 1st Parameter
- *boolean*: 2nd Parameter
- Returns nothing

### *PlaybackController[]* AgentGetWalkAnimatorIdleController(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a PlaybackController Array

### *PlaybackController[]* AgentGetWalkAnimatorForwardController(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a PlaybackController Array

### *number* AgentGetForwardAnimVelocity(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a number

### *Vector3* AgentGetLookAtPosition(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a Vector3

### *Vector3* AgentGetWorldPosBetweenNodes(*AgentObject*, *string*, *string*)
- *AgentObject*: 1st Parameter
- *string*: 2nd Parameter
- *string*: 3rd Parameter
- Returns a Vector3

### *void* Analytics_RecordEvent()
- Returns nothing

### *string* ActorToAgent(*string*)
- *string*: 1st Parameter
- Returns a string

### *string* AgentToActor(*string*)
- *string*: 1st Parameter
- Returns a string

### *string[]* AgentToModels(*string*)
- *string*: 1st Parameter
- Returns a string array

### *AgentObject* AgentCreate(*string*, *PropertySet*, *Vector3*, *Vector3*, *SceneObject*, *boolean*, *boolean*)
- *string*: 1st Parameter
- *PropertySet*: 2nd Parameter
- *Vector3*: 3rd Parameter
- *Vector3*: 4th Parameter
- *boolean*: 6th Parameter
- *boolean*: 7th Parameter
- Returns an AgentObject

### *AgentObject* AgentDuplicate(*string*, *AgentObject*, *boolean*, *boolean*, *boolean*, *boolean*, *boolean*, *SceneObject*)
- *string*: 1st Parameter
- *AgentObject*: 2nd Parameter
- *boolean*: 3rd Parameter ***(optional)***
- *boolean*: 4th Parameter ***(optional)***
- *boolean*: 5th Parameter ***(optional)***
- *boolean*: 6th Parameter ***(optional)***
- *boolean*: 7th Parameter ***(optional)***
- Returns an AgentObject

### *void* AgentDestroy(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns nothing

### *AgentObject* AgentAtCursorPos()
- Returns an AgentObject

### *void* AgentPreLoad(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns nothing

### *boolean* AgentIsUnderCursor(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a boolean

### *AgentObject* AgentAtScreenPos(*Vector2*, *boolean*, *SceneObject*)
- *Vector2*: 1st Parameter
- *boolean*: 2nd Parameter ***(optional)***
- Returns an AgentObject

### *AgentObject* AgentAtLogicalScreenPos(*Vector2*, *boolean*, *SceneObject*)
- *Vector2*: 1st Parameter
- *boolean*: 2nd Parameter ***(optional)***
- Returns an AgentObject

### *AgentObject[]* AgentsAtLogicalScreenPos(*Vector2*, *boolean*, *SceneObject*)
- *Vector2*: 1st Parameter
- *boolean*: 2nd Parameter ***(optional)***
- Returns an AgentObject array

### *boolean* AgentSelectionIsOccluded(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a boolean

### *void* AgentAttach(*AgentObject*, *AgentObject*, *boolean*)
- *AgentObject*: 1st Parameter
- *AgentObject*: 2nd Parameter
- *boolean*: 3rd Parameter ***(optional)***
- Returns nothing

### *void* AgentAttachToNode(*AgentObject*, *AgentObject*, *string*, *boolean*)
- *AgentObject*: 1st Parameter
- *AgentObject*: 2nd Parameter
- *string*: 3rd Parameter
- *boolean*: 4th Parameter ***(optional)***
- Returns nothing

### *void* AgentDetach(*AgentObject*, *boolean*)
- *AgentObject*: 1st Parameter
- *boolean*: 2nd Parameter ***(optional)***
- Returns nothing

### *boolean* AgentCollide(*AgentObject*, *AgentObject*)
- *AgentObject*: 1st Parameter
- *AgentObject*: 2nd Parameter
- Returns a boolean

### *boolean* AgentContaining(*AgentObject*, *AgentObject*)
- *AgentObject*: 1st Parameter
- *AgentObject*: 2nd Parameter
- Returns a boolean

### *AgentObject* AgentFind(*string*)
- *string*: 1st Parameter
- Returns an AgentObject

### *AgentObject* AgentFindInScene(*string*, *SceneObject*)
- *string*: 1st Parameter
- Returns an AgentObject

### *boolean* AgentExists(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a boolean

### *boolean* AgentExistsInScene(*AgentObject*, *SceneObject*)
- *AgentObject*: 1st Parameter
- Returns a boolean

### *Vector3* AgentGetPos(*AgentObject*, *string*)
- *AgentObject*: 1st Parameter
- *string*: 2nd Parameter ***(optional)***
- Returns a Vector3

### *void* AgentSetPos(*AgentObject*, *Vector3*, *boolean*)
- *AgentObject*: 1st Parameter
- *Vector3*: 2nd Parameter
- *boolean*: 3rd Parameter ***(optional)***
- Returns nothing

### *Vector3* AgentGetRot(*AgentObject*, *string*)
- *AgentObject*: 1st Parameter
- *string*: 2nd Parameter ***(optional)***
- Returns a Vector3

### *Quaternion* AgentGetQuat(*AgentObject*, *string*)
- *AgentObject*: 1st Parameter
- *string*: 2nd Parameter ***(optional)***
- Returns a Quaternion

### *void* AgentSetRot(*AgentObject*, *Vector3*, *boolean*)
- *AgentObject*: 1st Parameter
- *Vector3*: 2nd Parameter
- *boolean*: 3rd Parameter ***(optional)***
- Returns nothing

### *void* AgentSetRotFromQuat(*AgentObject*, *Quaternion*, *boolean*)
- *AgentObject*: 1st Parameter
- *Quaternion*: 2nd Parameter
- *boolean*: 3rd Parameter ***(optional)***
- Returns nothing

### *void* AgentIncYRot(*AgentObject*, *number*)
- *AgentObject*: 1st Parameter
- *number*: 2nd Parameter
- Returns nothing

### *void* AgentIncRot(*AgentObject*, *Vector3*, *number*)
- *AgentObject*: 1st Parameter
- *Vector3*: 2nd Parameter
- *number*: 3rd Parameter
- Returns nothing

### *Vector3* AgentGetForwardVec(*AgentObject*, *boolean*)
- *AgentObject*: 1st Parameter
- *boolean*: 2nd Parameter
- Returns a Vector3

### *Vector3* AgentGetRightVec(*AgentObject*, *boolean*)
- *AgentObject*: 1st Parameter
- *boolean*: 2nd Parameter
- Returns a Vector3

### *string* AgentGetName(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a string

### *void* AgentSetName(*AgentObject*, *string*)
- *AgentObject*: 1st Parameter
- *string*: 2nd Parameter
- Returns nothing

### *boolean* AgentIsAncestor(*AgentObject*, *AgentObject*)
- *AgentObject*: 1st Parameter
- *AgentObject*: 2nd Parameter
- Returns a boolean

### *AgentObject* AgentGetParent(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns an AgentObject

### *string* AgentGetParentNode(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a string

### *boolean* AgentHasChild(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a boolean

### *AgentObject* AgentGetChild(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns an AgentObject

### *AgentObject[]* AgentGetChildren(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns an AgentObject array

### *AgentObject[]* AgentGetAttachments(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns an AgentObject array

### *Vector3* AgentGetScreenPos(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a Vector3

### *Vector3* AgentGetLogicalScreenPos(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a Vector3

### *void* AgentSetWorldPosFromLogicalScreenPos(*AgentObject*, *Vector2*, *number*, *AgentObject*)
- *AgentObject*: 1st Parameter
- *Vector2*: 2nd Parameter
- *number*: 3rd Parameter ***(optional)***
- *AgentObject*: 4th Parameter ***(optional)***
- Returns nothing

### *Vector3* AgentGetSelectionScreenPos(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a Vector3

### *Vector3* AgentGetWorldRot(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a Vector3

### *Quaternion* AgentGetWorldRotQuat(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a Quaternion

### *void* AgentSetWorldRot(*AgentObject*, *Vector3*)
- *AgentObject*: 1st Parameter
- *Vector3*: 2nd Parameter
- Returns nothing

### *void* AgentSetWorldRotFromQuat(*AgentObject*, *Quaternion*)
- *AgentObject*: 1st Parameter
- *Quaternion*: 2nd Parameter
- Returns nothing

### *Vector3* AgentGetWorldPos(*AgentObject*, *string*)
- *AgentObject*: 1st Parameter
- *string*: 2nd Parameter ***(optional)***
- Returns a Vector3

### *boolean* AgentHasNode(*AgentObject*, *string*)
- *AgentObject*: 1st Parameter
- *string*: 2nd Parameter
- Returns a boolean

### *void* AgentSetWorldPos(*AgentObject*, *Vector3*)
- *AgentObject*: 1st Parameter
- *Vector3*: 2nd Parameter
- Returns nothing

### *void* AgentSetWorldPosFromScreenPos(*AgentObject*, *Vector2*, *number*)
- *AgentObject*: 1st Parameter
- *Vector2*: 2nd Parameter
- *number*: 3rd Parameter ***(optional)***
- Returns nothing

### *Vector3* AgentGetWorldPosFromScreenPos(*AgentObject*, *Vector2*, *number*)
- *AgentObject*: 1st Parameter
- *Vector2*: 2nd Parameter
- *number*: 3rd Parameter ***(optional)***
- Returns a Vector3

### *void* AgentSetWorldPosFromCursorPos(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns nothing

### *Vector3* AgentGetWorldPosFromCursorPos(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a Vector3

### *void* AgentHide(*AgentObject*, *boolean*, *boolean*)
- *AgentObject*: 1st Parameter
- *boolean*: 2nd Parameter
- *boolean*: 3rd Parameter ***(optional)***
- Returns nothing

### *void* AgentInsert(*AgentObject*, *AgentObject*)
- *AgentObject*: 1st Parameter
- *AgentObject*: 2nd Parameter
- Returns nothing

### *boolean* AgentIsHidden(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a boolean

### *void* AgentFacePos(*AgentObject*, *Vector3*, *boolean*)
- *AgentObject*: 1st Parameter
- *Vector3*: 2nd Parameter
- *boolean*: 3rd Parameter ***(optional)***
- Returns nothing

### *PropertySet* AgentGetProperties(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a PropertySet

### *PropertySet* AgentGetTransientProperties(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a PropertySet

### *PropertySet* AgentGetRuntimeProperties(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a PropertySet

### *PropertySet* AgentGetSceneProperties(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a PropertySet

### *PropertySet* AgentGetClassProperties(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a PropertySet

### *DataType* AgentGetProperty(*AgentObject*, *string*, *boolean*)
- *AgentObject*: 1st Parameter
- *string*: 2nd Parameter
- *boolean*: 3rd Parameter
- Returns a DataType (Note this can be any data type depending on the property)

### *boolean* AgentHasProperty(*AgentObject*, *string*)
- *AgentObject*: 1st Parameter
- *string*: 2nd Parameter
- Returns a boolean

### *void* AgentSetProperty(*AgentObject*, *string*, *DataType*)
- *AgentObject*: 1st Parameter
- *string*: 2nd Parameter
- *DataType*: 3rd Parameter (Note this can be any data type depending on the property)
- Returns nothing

### *void* AgentSetSceneProperty(*AgentObject*, *string*, *DataType*)
- *AgentObject*: 1st Parameter
- *string*: 2nd Parameter
- *DataType*: 3rd Parameter (Note this can be any data type depending on the property)
- Returns nothing

### *void* AgentRemovePropertyKeyValues(*AgentObject*, *PropertySet*, *PropertySet*)
- *AgentObject*: 1st Parameter
- *PropertySet*: 2nd Parameter
- *PropertySet*: 3rd Parameter
- Returns nothing

### *void* AgentImportPropertyKeyValues(*AgentObject*, *PropertySet*, *PropertySet*)
- *AgentObject*: 1st Parameter
- *PropertySet*: 2nd Parameter
- *PropertySet*: 3rd Parameter
- Returns nothing

### *void* AgentImportAgentPropertyKeyValues(*AgentObject*, *AgentObject*, *PropertySet*)
- *AgentObject*: 1st Parameter
- *AgentObject*: 2nd Parameter
- *PropertySet*: 3rd Parameter
- Returns nothing

### *boolean* AgentIsParentProperty(*AgentObject*, *PropertySet*)
- *AgentObject*: 1st Parameter
- *PropertySet*: 2nd Parameter
- Returns a boolean

### *boolean* AgentRestore(*AgentObject*, *number*)
- *AgentObject*: 1st Parameter
- *number*: 2nd Parameter ***(optional)***
- Returns a boolean

### *void* AgentSetSelectable(*AgentObject*, *PropertySet*)
- *AgentObject*: 1st Parameter
- *PropertySet*: 2nd Parameter
- Returns nothing

### *AgentObject* AgentGetCamera(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns an AgentObject

### *void* AgentEnableMover(*AgentObject*, *boolean*)
- *AgentObject*: 1st Parameter
- *boolean*: 2nd Parameter
- Returns nothing

### *SceneObject* AgentGetScene(*AgentObject*)
- *AgentObject*: 1st Parameter

### *number* AgentGetPixelScale(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a number

### *number* AgentDistanceToAgent(*AgentObject*, *AgentObject*)
- *AgentObject*: 1st Parameter
- *AgentObject*: 2nd Parameter
- Returns a number

### *number* AgentDistanceToScreenPos(*AgentObject*, *Vector3*)
- *AgentObject*: 1st Parameter
- *Vector3*: 2nd Parameter
- Returns a number

### *number* AgentScreenArea(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a number

### *Vector3* AgentGetSelectionCenter(*AgentObject*, *boolean*)
- *AgentObject*: 1st Parameter
- *boolean*: 2nd Parameter ***(optional)***
- Returns a Vector3

### *Vector3* AgentLocalToWorld(*AgentObject*, *Vector3*)
- *AgentObject*: 1st Parameter
- *Vector3*: 2nd Parameter
- Returns a Vector3

### *Vector3* AgentWorldToLocal(*AgentObject*, *Vector3*)
- *AgentObject*: 1st Parameter
- *Vector3*: 2nd Parameter
- Returns a Vector3

### *Vector3* AgentRotateToWorld(*AgentObject*, *Vector3*)
- *AgentObject*: 1st Parameter
- *Vector3*: 2nd Parameter
- Returns a Vector3

### *Vector3* AgentRotateToLocal(*AgentObject*, *Vector3*)
- *AgentObject*: 1st Parameter
- *Vector3*: 2nd Parameter
- Returns a Vector3

### *number* AgentGetAnglesTo(*AgentObject*, *Vector3*, *Vector3*)
- *AgentObject*: 1st Parameter
- *Vector3*: 2nd Parameter
- *Vector3*: 3rd Parameter ***(optional)***
- Returns a number

### *boolean* AgentIsOnScreen(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a boolean

### *boolean* AgentIsReferenced(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a boolean

### *boolean* AgentIsValid(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a boolean

### *boolean* AgentTurnTowards(*AgentObject*, *number*, *Vector3*)
- *AgentObject*: 1st Parameter
- *number*: 2nd Parameter
- *Vector3*: 3rd Parameter
- Returns a boolean

### *void* AgentAddOnDestroyCallback(*AgentObject*, *LUAFunction*)
- *AgentObject*: 1st Parameter
- Returns nothing

### *boolean* AgentRemoveOnDestroyCallback(*AgentObject*, *LUAFunction*)
- *AgentObject*: 1st Parameter
- Returns a boolean

### *Vector3* AgentGetCorner(*AgentObject*, *number*)
- *AgentObject*: 1st Parameter
- *number*: 2nd Parameter
- Returns a Vector3

### *void* AgentResetSkeletonHomogenousInfo(*AgentObject*, *Skeleton*)
- *AgentObject*: 1st Parameter
- Returns nothing

### *void* AgentSetLightingForAllTextures(*AgentObject*, *string*)
- *AgentObject*: 1st Parameter
- *string*: 2nd Parameter
- Returns nothing

### *boolean* AgentHasAlphaBlendedTexture(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a boolean

### *PlaybackController[]* AgentGetControllers(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a PlaybackController Array

### *number* AgentGetPriorityOfHighestPriorityContoller(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a number

### *void* AgentSetRotIfNoActiveTransformKeys(*AgentObject*, *Vector3*, *string*)
- *AgentObject*: 1st Parameter
- *Vector3*: 2nd Parameter
- *string*: 3rd Parameter
- Returns nothing

### *boolean* AgentContainingPos(*AgentObject*, *Vector3*)
- *AgentObject*: 1st Parameter
- *Vector3*: 2nd Parameter
- Returns a boolean

### *boolean* AnimationCreate()
- Returns a boolean

### *string* AnimationGetName(*Animation*)
- Returns a string

### *number* AnimationGetLength(*Animation*)
- Returns a number

### *boolean* AnimationClear(*Animation*)
- Returns a boolean

<!-- ### *LuaAnimatedValueBase* AnimationAddLuaEntry(*Animation*) -->

### *void* AdvanceActiveSubtitles()
- Returns nothing

### *PlaybackController* AudioPlay(*SoundData*, *number*, *number*)
- *SoundData*: 1st Parameter
- *number*: 2nd Parameter ***(optional)***
- *number*: 3rd Parameter ***(optional)***
- Returns a PlaybackController

### *void* AudioPlayAndWait(*SoundData*, *number*, *number*)
- *SoundData*: 1st Parameter
- *number*: 2nd Parameter ***(optional)***
- *number*: 3rd Parameter ***(optional)***
- Returns nothing

# B

### *boolean* BeginOffersEnumeration()
- Returns a boolean

### *boolean* BeginPurchaseEpisode()
- Returns a boolean

### *boolean* BeginUpdateEpisodes()
- Returns a boolean

### *Symbol* Base64ToSymbol(*string*)
- *string*: 1st Parameter
- Returns a Symbol

### *ResourceBundle* BundleCreateResource(*ResourceBundle*, *string*)
- *string*: 2nd Parameter
- Returns a ResourceBundle

### *boolean* BundleRemoveResource(*ResourceBundle*, *Symbol*)
- Returns a boolean

### *ResourceBundle* BundleGetResource(*ResourceBundle*, *Symbol*)
- Returns a ResourceBundle

### *ResourceBundle[]* BundleGetResources(*ResourceBundle*, *Symbol*)
- Returns a ResourceBundle Array

### *void* BreakIntoDebugger()
- Returns nothing

# C

### *boolean* CheckEDATKey(*string*)
- *string*: 2nd Parameter
- Returns a boolean

### *void* CSISendTracking(*string*, *string*, *boolean*)
- *string*: 1st Parameter
- *string*: 2nd Parameter
- *boolean*: 3rd Parameter
- Returns nothing

### *void* ConsoleSetVerbosity(*number*)
- *number*: 1st Parameter
- Returns nothing

### *void* ConsoleSetChannel(*number*, *boolean*)
- *number*: 1st Parameter
- *boolean*: 2nd Parameter
- Returns nothing

### *Color* Color(*number*, *number*, *number*, *number*)
- *number*: 1st Parameter
- *number*: 2nd Parameter
- *number*: 3rd Parameter
- *number*: 4th Parameter

### *void* CanActivateSystemHUD()
- Returns nothing

### *Symbol* CRCToSymbol(*string*)
- *string*: 1st Parameter

### *void* CriticalError(*string*)
- *string*: 1st Parameter
- Returns nothing

### *void* ControllerPlay(*PlaybackController*)
- Returns nothing

### *void* ControllerPause(*PlaybackController*)
- Returns nothing

### *void* ControllerStop(*PlaybackController*)
- Returns nothing

### *void* ControllerWait(*PlaybackController*)
- Returns nothing

### *void* ControllerFadeIn(*PlaybackController*, *number*, *boolean*)
- *number*: 2nd Parameter
- *boolean*: 3rd Parameter
- Returns nothing

### *void* ControllerFadeOut(*PlaybackController*, *number*, *boolean*)
- *number*: 2nd Parameter
- *boolean*: 3rd Parameter
- Returns nothing

### *void* ControllerFadeTo(*PlaybackController*, *number*, *number*, *boolean*)
- *number*: 2nd Parameter
- *number*: 3rd Parameter
- *boolean*: 4th Parameter
- Returns nothing

### *void* ControllerSetTimeScale(*PlaybackController*, *number*)
- *number*: 2nd Parameter
- Returns nothing

### *number* ControllerGetTimeScale(*PlaybackController*)
- Returns a number

### *void* ControllerKill(*PlaybackController*)
- Returns nothing

### *number* ControllerGetLength(*PlaybackController*)
- Returns a number

### *void* ControllerSetLength(*PlaybackController*, *number*)
- *number*: 2nd Parameter
- Returns nothing

### *boolean* ControllerIsPlaying(*PlaybackController*)
- Returns a boolean

### *boolean* ControllerIsPaused(*PlaybackController*)
- Returns a boolean

### *void* ControllerSetVolume(*PlaybackController*, *number*)
- *number*: 2nd Parameter
- Returns nothing

### *void* ControllerSetSoundVolume(*PlaybackController*, *number*)
- *number*: 2nd Parameter
- Returns nothing

### *void* ControllerSetLooping(*PlaybackController*, *boolean*)
- *boolean*: 2nd Parameter
- Returns nothing

### *void* ControllerSetMirrored(*PlaybackController*, *boolean*)
- *boolean*: 2nd Parameter
- Returns nothing

### *void* ControllerSetEndPause(*PlaybackController*, *boolean*)
- *boolean*: 2nd Parameter
- Returns nothing

### *void* ControllerSetBeginPause(*PlaybackController*, *boolean*)
- *boolean*: 2nd Parameter
- Returns nothing

### *number* ControllerGetTime(*PlaybackController*)
- Returns a number

### *void* ControllerSetTime(*PlaybackController*, *number*)
- *number*: 2nd Parameter
- Returns nothing

### *void* ControllerSetTimePercent(*PlaybackController*, *number*)
- *number*: 2nd Parameter
- Returns nothing

### *number* ControllerGetContribution(*PlaybackController*)
- Returns a number

### *void* ControllerSetContribution(*PlaybackController*, *number*)
- *number*: 2nd Parameter
- Returns nothing

### *void* ControllerDisableTimeSync(*PlaybackController*, *boolean*)
- *boolean*: 2nd Parameter
- Returns nothing

### *void* ControllerSetVoice(*PlaybackController*, *boolean*)
- *boolean*: 2nd Parameter
- Returns nothing

### *void* ControllerSetMusic(*PlaybackController*, *boolean*)
- *boolean*: 2nd Parameter
- Returns nothing

### *void* ControllerSetAmbient(*PlaybackController*, *boolean*)
- *boolean*: 2nd Parameter
- Returns nothing

### *void* ControllerSetLanguage(*PlaybackController*, *boolean*)
- *boolean*: 2nd Parameter
- Returns nothing

### *void* ControllerSetName(*PlaybackController*, *string*)
- *string*: 2nd Parameter
- Returns nothing

### *PlaybackController* ControllerFind(*string*)
- *string*: 1st Parameter
- Returns a PlaybackController

### *void* ControllerDrift(*PlaybackController*, *boolean*)
- *boolean*: 2nd Parameter
- Returns nothing

### *void* ControllerSetPriority(*PlaybackController*, *number*)
- *number*: 2nd Parameter
- Returns nothing

### *number* ControllerGetPriority(*PlaybackController*)
- Returns a number

### *void* ControllerSetScene(*PlaybackController*, *SceneObject*)
- Returns nothing

### *Chore* ControllerGetChore(*PlaybackController*)
- Returns a Chore

### *PlaybackController* ControllerGetParent(*PlaybackController*, *boolean*)
- *boolean*: 2nd Parameter
- Returns a PlaybackController

### *boolean* Create(*string*)
- *string*: 1st Parameter
- Returns a boolean

### *void* CacheSaveGameImage()
- Returns nothing

### *void* CameraActivate(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns nothing

### *Vector3* CameraGetScreenPosFromWorldPos(*AgentObject*, *Vector3*)
- *AgentObject*: 1st Parameter
- *Vector3*: 2nd Parameter
- Returns a Vector3

### *void* CameraPush(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns nothing

### *void* CameraPop(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns nothing

### *void* CameraSettle(*AgentObject*, *boolean*)
- *AgentObject*: 1st Parameter
- *boolean*: 2nd Parameter
- Returns nothing

### *number* CameraGetFOV(*AgentObject*)
- Returns a number
- *AgentObject*: 1st Parameter

### *void* CameraSetFOV(*AgentObject*, *number*)
- *AgentObject*: 1st Parameter
- *number*: 2nd Parameter
- Returns nothing

### *void* CameraSetNavTarget(*AgentObject*, *AgentObject*)
- *AgentObject*: 1st Parameter
- *AgentObject*: 2nd Parameter
- Returns nothing

### *void* CameraSetNavTargetOffset(*AgentObject*, *number*, *number*, *number*)
- *AgentObject*: 1st Parameter
- *number*: 2nd Parameter
- *number*: 3rd Parameter
- *number*: 4th Parameter
- Returns nothing

### *void* CameraSetNavHome(*AgentObject*, *number*, *number*, *number*)
- *AgentObject*: 1st Parameter
- *number*: 2nd Parameter
- *number*: 3rd Parameter
- *number*: 4th Parameter
- Returns nothing

### *void* CameraSetNavMode(*AgentObject*, *string*)
- *AgentObject*: 1st Parameter
- *string*: 2nd Parameter
- Returns nothing

### *void* CameraSetNavResetOnActivate(*AgentObject*, *boolean*)
- *AgentObject*: 1st Parameter
- *boolean*: 2nd Parameter
- Returns nothing

### *void* CameraSetNavChore(*AgentObject*, *Chore*)
- *AgentObject*: 1st Parameter
- *Chore*: 2nd Parameter
- Returns nothing

### *boolean* CameraGetSettled(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a boolean

### *Vector3* CameraGetLogicalScreenPos(*AgentObject*, *Vector3*)
- *AgentObject*: 1st Parameter
- *Vector3*: 2nd Parameter
- Returns a Vector3

### *Vector3* CameraGetWorldPosFromLogicalScreenPos(*AgentObject*, *Vector3*, *number*)
- *AgentObject*: 1st Parameter
- *Vector3*: 2nd Parameter
- *number*: 3rd Parameter
- Returns a Vector3

### *void* CameraSetUserInputEnabled(*boolean*)
- *boolean*: 1st Parameter
- Returns nothing

### *void* CameraBlendPush(*AgentObject*, *number*, *number*, *number*)
- *AgentObject*: 1st Parameter
- *number*: 2nd Parameter
- *number*: 3rd Parameter
- *number*: 4th Parameter
- Returns nothing

### *void* CameraBlendPop(*AgentObject*, *number*, *number*, *number*)
- *AgentObject*: 1st Parameter
- *number*: 2nd Parameter
- *number*: 3rd Parameter
- *number*: 4th Parameter
- Returns nothing

### *PlaybackController* ChorePlay(*Chore*, *number*)
- *Chore*: 1st Parameter
- *number*: 2nd Parameter
- Returns a PlaybackController

### *void* ChoreSetAgentRemap(*string*, *string*)
- *string*: 1st Parameter
- *string*: 2nd Parameter
- Returns nothing

### *void* ChorePlayAndWait(*Chore*, *number*, *number*, *number*)
- *Chore*: 1st Parameter
- *number*: 2nd Parameter
- *number*: 3rd Parameter
- *number*: 4th Parameter
- Returns nothing

### *AgentObject[]* ChoreGetAgents(*Chore*)
- *Chore*: 1st Parameter
- Returns an AgentObject array

### *string[]* ChoreGetAgentNames(*Chore*)
- *Chore*: 1st Parameter
- Returns a string array

### *number* ChoreGetLength(*Chore*)
- Returns a number
- *Chore*: 1st Parameter

### *boolean* ChoreGetLength(*Chore*, *number*)
- *Chore*: 1st Parameter
- *number*: 2nd Parameter
- Returns a boolean

### *AgentObject* ChoreGetAgentAttachment(*Chore*, *string*)
- *Chore*: 1st Parameter
- *string*: 2nd Parameter
- Returns an AgentObject

### *Symbol[]* ChoreGetPropertyKeysAsStrings(*Chore*, *string*, *string*)
- *Chore*: 1st Parameter
- *string*: 2nd Parameter
- *string*: 3rd Parameter
- Returns a Symbol array

### *Symbol[]* ChoreGetBlockingKeysTable(*Chore*, *string*)
- *Chore*: 1st Parameter
- *string*: 2nd Parameter
- Returns a Symbol array

### *boolean* ChoreRemoveAgent(*Chore*, *string*)
- *Chore*: 1st Parameter
- *string*: 2nd Parameter
- Returns a boolean

### *void* ChoreSetAttachmentAgent(*Chore*, *string*, *string*, *string*)
- *Chore*: 1st Parameter
- *string*: 2nd Parameter
- *string*: 3rd Parameter
- *string*: 4th Parameter
- Returns nothing

### *void* ChoreSetAttachmentPosition(*Chore*, *string*, *number*, *number*, *number*)
- *Chore*: 1st Parameter
- *string*: 2nd Parameter
- *number*: 3rd Parameter
- *number*: 4th Parameter
- *number*: 5th Parameter
- Returns nothing

### *void* ChoreSetAttachmentRotation(*Chore*, *string*, *number*, *number*, *number*)
- *Chore*: 1st Parameter
- *string*: 2nd Parameter
- *number*: 3rd Parameter
- *number*: 4th Parameter
- *number*: 5th Parameter
- Returns nothing

### *void* ChoreSetAttachmentQuaternion(*Chore*, *string*, *number*, *number*, *number*, *number*)
- *Chore*: 1st Parameter
- *string*: 2nd Parameter
- *number*: 3rd Parameter
- *number*: 4th Parameter
- *number*: 5th Parameter
- Returns nothing

### *void* ChoreSetAttachmentPreserveWorldPos(*Chore*, *string*, *boolean*)
- *Chore*: 1st Parameter
- *string*: 2nd Parameter
- *boolean*: 3rd Parameter
- Returns nothing

### *void* ChoreSetAttachmentLeaveAttached(*Chore*, *string*, *boolean*)
- *Chore*: 1st Parameter
- *string*: 2nd Parameter
- *boolean*: 3rd Parameter
- Returns nothing

### *void* ChoreAddAttachmentKey(*Chore*, *string*, *number*, *string*, *string*, *Symbol*, *boolean*, *Vector3*, *Quaternion*)
- *Chore*: 1st Parameter
- *string*: 2nd Parameter
- *number*: 3rd Parameter
- *string*: 4th Parameter
- *string*: 5th Parameter
- *boolean*: 7th Parameter
- *Vector3*: 8th Parameter
- *Quaternion*: 9th Parameter
- Returns nothing

### *void* ChoreResourceRemoveAnimatedValue(*Chore*, *number*, *string*)
- *Chore*: 1st Parameter
- *number*: 2nd Parameter
- *string*: 3rd Parameter
- Returns nothing

### *void* ChoreAgentEnableRandomSFX(*Chore*, *AgentObject*)
- *Chore*: 1st Parameter
- *AgentObject*: 2nd Parameter
- Returns nothing

### *void* ChoreForceLookAtConstraint(*AgentObject*, *string*, *string*, *number*)
- *AgentObject*: 1st Parameter
- *string*: 2nd Parameter
- *string*: 3rd Parameter
- *number*: 4th Parameter
- Returns nothing

### *boolean* ChoreGetResetNavCamsOnExit(*Chore*)
- *Chore*: 1st Parameter
- Returns a boolean

### *boolean* ChoreGetBackgroundFade(*Chore*)
- *Chore*: 1st Parameter
- Returns a boolean

### *boolean* ChoreGetBackgroundLoop(*Chore*)
- *Chore*: 1st Parameter
- Returns a boolean

### *boolean* ChoreGetEndPause(*Chore*)
- *Chore*: 1st Parameter
- Returns a boolean

<!-- ### *SceneObject* ChoreGetBaseChore(*Chore*) -->
<!-- - *Chore*: 1st Parameter --> 
<!-- - Returns a SceneObject -->

<!-- ### *SceneObject* ChoreGetMasterCut(*Chore*) -->
<!-- - *Chore*: 1st Parameter -->
<!-- - Returns a SceneObject -->

<!-- ### *nil* ChoreGetCut(*Chore*, *Symbol*) -->
<!-- - *Chore*: 1st Parameter -->
<!-- - Returns a nil -->

<!-- ### *nil* ChoreGoToPauseAndKill(*Chore*, *number*) -->
<!-- - *Chore*: 1st Parameter -->
<!-- - *number*: 2nd Parameter -->
<!-- - Returns a nil -->

### *void* ChoreRegenerateStyleIdleTransition(*string*)
- *string*: 1st Parameter
- Returns nothing

### *string[]* ChoreGetAttachmentData(*Chore*, *string*)
- *Chore*: 1st Parameter
- *string*: 2nd Parameter
- Returns a string array

### *number* ContainerGetNumElements(*ContainerInterface*)
- Returns a number

### *ContainerInterface* ContainerGetElement(*ContainerInterface*, *string*)
- *string*: 2nd Parameter
- Returns a ContainerInterface

### *string* ContainerGetElementName(*ContainerInterface*, *number*)
- *number*: 2nd Parameter
- Returns a string

### *void* ContainerClear(*ContainerInterface*)
- Returns nothing

<!-- ### *void* ContainerInsertElement(*ContainerInterface*) -->

<!-- ### *void* ContainerRemoveElement(*ContainerInterface*, *string*, *PropertySet*) -->
<!-- - *string*: 2nd Parameter -->
<!-- - *PropertySet*: 3rd Parameter -->

<!-- ### *void* ContainerSetElement(*ContainerInterface*, *string*, *PropertySet*) -->
<!-- - *string*: 2nd Parameter -->
<!-- - *PropertySet*: 3rd Parameter -->

### *void* CursorEnableMultiple(*boolean*, *number*)
- *boolean*: 1st Parameter
- *number*: 2nd Parameter
- Returns nothing

### *void* CursorSet(*PropertySet*, *number*)
- *PropertySet*: 1st Parameter
- *number*: 2nd Parameter
- Returns nothing

### *void* CursorReset(*number*)
- *number*: 1st Parameter
- Returns nothing

<!-- ### *void* CursorConfine(*Vector2*, *Vector2*) -->
<!-- - *Vector2*: 1st Parameter -->
<!-- - *Vector2*: 2nd Parameter -->
<!-- - Returns nothing -->

### *Vector3* CursorGetPos(*number*)
- *number*: 1st Parameter
- Returns a Vector3

### *Vector3* CursorGetDevicePos(*number*)
- *number*: 1st Parameter
- Returns a Vector3

### *void* CursorSetAtScreenCenter(*number*)
- *number*: 1st Parameter
- Returns nothing

### *void* CursorSetPos(*Vector2*, *number*)
- *Vector2*: 1st Parameter
- *number*: 2nd Parameter
- Returns nothing

### *void* CursorHide(*boolean*, *number*)
- *boolean*: 1st Parameter
- *number*: 2nd Parameter
- Returns nothing

### *boolean* CursorHidden(*number*)
- *number*: 1st Parameter
- Returns a boolean

### *void* CursorEnable(*boolean*, *number*)
- *boolean*: 1st Parameter
- *number*: 2nd Parameter
- Returns nothing

### *boolean* CursorIsEnabled(*number*)
- *number*: 1st Parameter
- Returns a boolean

### *void* CursorSetTexture(*T3Texture*, *number*)
- *number*: 2nd Parameter
- Returns nothing

### *void* CursorSetOffset(*number*, *number*, *number*)
- *number*: 1st Parameter
- *number*: 2nd Parameter
- *number*: 3rd Parameter
- Returns nothing

### *T3Texture* CursorGetTexture(*number*)
- *number*: 1st Parameter
- Returns a T3Texture

### *void* CursorSetSize(*number*, *number*)
- *number*: 1st Parameter
- *number*: 2nd Parameter
- Returns nothing

### *void* CursorSetColor(*number*, *number*, *number*, *number*, *number*)
- *number*: 1st Parameter
- *number*: 2nd Parameter
- *number*: 3rd Parameter
- *number*: 4th Parameter
- *number*: 5th Parameter
- Returns nothing

### *Vector3* CursorGet3DOrigin(*SceneObject*)
- Returns a Vector3

### *Vector3* CursorGet3DDirection(*SceneObject*)
- Returns a Vector3

### *AgentObject* CursorGetAgent(*number*)
- *number*: 1st Parameter
- Returns an AgentObject

### *Vector3* CursorGetPointOnAgent(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a Vector3

### *void* CursorEnableRelativeMode(*boolean*)
- *boolean*: 1st Parameter
- Returns nothing

### *void* CreateEventLogEvent(*string*, *number*, *boolean*)
- *number*: 2nd Parameter
- *boolean*: 3rd Parameter
- Returns nothing

<!-- ### *void* CreateSessionEventLog(*string*, *number*, *boolean*) -->
<!-- - *string*: 1st Parameter -->
<!-- - *number*: 2nd Parameter -->
<!-- - *boolean*: 3rd Parameter -->
<!-- - Returns nothing -->

More to be added...