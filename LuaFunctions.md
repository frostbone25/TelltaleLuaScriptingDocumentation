Telltale Lua Scripting Documentation

# A

### *boolean* AppleControllerIsConnected()
- Returns a boolean

### *void* AppleGameControllerSetConnectedCallback(*string*)
- *string*: 1st Parameter
- No returned value

### *void* AppleGameControllerSetDisconnectedCallback(*string*)
- *string*: 1st Parameter
- No returned value

### *void* ActivateSystemHUD()
- No returned value

### *void* AgentSetWalkAnimatorPrevPos(*AgentObject*, *Vector3*)
- *AgentObject*: 1st Parameter
- *Vector3*: 2nd Parameter
- No returned value

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
- No returned value

### *void* AgentSetRunning(*AgentObject*, *boolean*)
- *AgentObject*: 1st Parameter
- *boolean*: 2nd Parameter
- No returned value

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
- No returned value

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
- No returned value

### *AgentObject* AgentAtCursorPos()
- Returns an AgentObject

### *void* AgentPreLoad(*AgentObject*)
- *AgentObject*: 1st Parameter
- No returned value

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
- No returned value

### *void* AgentAttachToNode(*AgentObject*, *AgentObject*, *string*, *boolean*)
- *AgentObject*: 1st Parameter
- *AgentObject*: 2nd Parameter
- *string*: 3rd Parameter
- *boolean*: 4th Parameter ***(optional)***
- No returned value

### *void* AgentDetach(*AgentObject*, *boolean*)
- *AgentObject*: 1st Parameter
- *boolean*: 2nd Parameter ***(optional)***
- No returned value

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
- No returned value

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
- No returned value

### *void* AgentSetRotFromQuat(*AgentObject*, *Quaternion*, *boolean*)
- *AgentObject*: 1st Parameter
- *Quaternion*: 2nd Parameter
- *boolean*: 3rd Parameter ***(optional)***
- No returned value

### *void* AgentIncYRot(*AgentObject*, *number*)
- *AgentObject*: 1st Parameter
- *number*: 2nd Parameter
- No returned value

### *void* AgentIncRot(*AgentObject*, *Vector3*, *number*)
- *AgentObject*: 1st Parameter
- *Vector3*: 2nd Parameter
- *number*: 3rd Parameter
- No returned value

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
- No returned value

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
- No returned value

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
- No returned value

### *void* AgentSetWorldRotFromQuat(*AgentObject*, *Quaternion*)
- *AgentObject*: 1st Parameter
- *Quaternion*: 2nd Parameter
- No returned value

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
- No returned value

### *void* AgentSetWorldPosFromScreenPos(*AgentObject*, *Vector2*, *number*)
- *AgentObject*: 1st Parameter
- *Vector2*: 2nd Parameter
- *number*: 3rd Parameter ***(optional)***
- No returned value

### *Vector3* AgentGetWorldPosFromScreenPos(*AgentObject*, *Vector2*, *number*)
- *AgentObject*: 1st Parameter
- *Vector2*: 2nd Parameter
- *number*: 3rd Parameter ***(optional)***
- Returns a Vector3

### *void* AgentSetWorldPosFromCursorPos(*AgentObject*)
- *AgentObject*: 1st Parameter
- No returned value

### *Vector3* AgentGetWorldPosFromCursorPos(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a Vector3

### *void* AgentHide(*AgentObject*, *boolean*, *boolean*)
- *AgentObject*: 1st Parameter
- *boolean*: 2nd Parameter
- *boolean*: 3rd Parameter ***(optional)***
- No returned value

### *void* AgentInsert(*AgentObject*, *AgentObject*)
- *AgentObject*: 1st Parameter
- *AgentObject*: 2nd Parameter
- No returned value

### *boolean* AgentIsHidden(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns a boolean

### *void* AgentFacePos(*AgentObject*, *Vector3*, *boolean*)
- *AgentObject*: 1st Parameter
- *Vector3*: 2nd Parameter
- *boolean*: 3rd Parameter ***(optional)***
- No returned value

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
- No returned value

### *void* AgentSetSceneProperty(*AgentObject*, *string*, *DataType*)
- *AgentObject*: 1st Parameter
- *string*: 2nd Parameter
- *DataType*: 3rd Parameter (Note this can be any data type depending on the property)
- No returned value

### *void* AgentRemovePropertyKeyValues(*AgentObject*, *PropertySet*, *PropertySet*)
- *AgentObject*: 1st Parameter
- *PropertySet*: 2nd Parameter
- *PropertySet*: 3rd Parameter
- No returned value

### *void* AgentImportPropertyKeyValues(*AgentObject*, *PropertySet*, *PropertySet*)
- *AgentObject*: 1st Parameter
- *PropertySet*: 2nd Parameter
- *PropertySet*: 3rd Parameter
- No returned value

### *void* AgentImportAgentPropertyKeyValues(*AgentObject*, *AgentObject*, *PropertySet*)
- *AgentObject*: 1st Parameter
- *AgentObject*: 2nd Parameter
- *PropertySet*: 3rd Parameter
- No returned value

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
- No returned value

### *AgentObject* AgentGetCamera(*AgentObject*)
- *AgentObject*: 1st Parameter
- Returns an AgentObject

### *void* AgentEnableMover(*AgentObject*, *boolean*)
- *AgentObject*: 1st Parameter
- *boolean*: 2nd Parameter
- No returned value

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
- No returned value

### *boolean* AgentRemoveOnDestroyCallback(*AgentObject*, *LUAFunction*)
- *AgentObject*: 1st Parameter
- Returns a boolean

### *Vector3* AgentGetCorner(*AgentObject*, *number*)
- *AgentObject*: 1st Parameter
- *number*: 2nd Parameter
- Returns a Vector3

### *void* AgentResetSkeletonHomogenousInfo(*AgentObject*, *Skeleton*)
- *AgentObject*: 1st Parameter
- No returned value

### *void* AgentSetLightingForAllTextures(*AgentObject*, *string*)
- *AgentObject*: 1st Parameter
- *string*: 2nd Parameter
- No returned value

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
- No returned value

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

<!-- ### AnimationAddLuaEntry() -->

### *void* AdvanceActiveSubtitles()
- No returned value

### *PlaybackController* AudioPlay(*SoundData*, *number*, *number*)
- *SoundData*: 1st Parameter
- *number*: 2nd Parameter ***(optional)***
- *number*: 3rd Parameter ***(optional)***
- Returns a PlaybackController

### *void* AudioPlayAndWait(*SoundData*, *number*, *number*)
- *SoundData*: 1st Parameter
- *number*: 2nd Parameter ***(optional)***
- *number*: 3rd Parameter ***(optional)***
- No returned value

# B

### *boolean* BeginOffersEnumeration()
- Returns a boolean
- This function does nothing

### *boolean* BeginPurchaseEpisode()
- Returns a boolean
- This function does nothing

### *boolean* BeginUpdateEpisodes()
- Returns a boolean
- This function does nothing

### *Symbol* Base64ToSymbol(*string*)
- *string*: 1st Parameter
- Returns a Symbol, if string length is not equal to 8 it will return nil

### *ResourceBundle* BundleCreateResource(*ResourceBundle*, *string*)
- *ResourceBundle*: 1st Parameter
- *string*: 2nd Parameter
- Returns a ResourceBundle

### *boolean* BundleRemoveResource(*ResourceBundle*, *Symbol*)
- *ResourceBundle*: 1st Parameter
- *Symbol*: 2nd Parameter (Note: Symbol is a string)
- Returns a boolean

### *ResourceBundle* BundleGetResource(*ResourceBundle*, *Symbol*)
- *ResourceBundle*: 1st Parameter
 *Symbol*: 2nd Parameter (Note: Symbol is a string)
- Returns a ResourceBundle

### *ResourceBundle[]* BundleGetResources(*ResourceBundle*, *Symbol*)
- *ResourceBundle*: 1st Parameter
 *Symbol*: 2nd Parameter (Note: Symbol is a string) ***(optional)***
- Returns a ResourceBundle Array

### *void* BreakIntoDebugger()
- No returned value
- This function does nothing

# C

### *boolean* CheckEDATKey(*string*)
- *string*: 1st Parameter
- Returns a boolean

### *void* CSISendTracking(*string*, *string*, *boolean*)
- *string*: 1st Parameter
- *string*: 2nd Parameter
- *boolean*: 3rd Parameter
- No returned value

### *void* ConsoleSetVerbosity(*number*)
- *number*: 1st Parameter, this expects a signed integer number
- No returned value

### *void* ConsoleSetChannel(*number*, *boolean*)
- *number*: 1st Parameter, this expects a signed integer number
- *boolean*: 2nd Parameter
- No returned value

### *Color* Color(*number*, *number*, *number*, *number*)
- *number*: 1st Parameter, Float Value, Red Channel
- *number*: 2nd Parameter, Float Value, Green Channel
- *number*: 3rd Parameter, Float Value, Blue Channel
- *number*: 4th Parameter, Float Value, Alpha Channel ***(optional)***
- Returns a Color object.

### *void* CanActivateSystemHUD()
- No returned value
- This function does nothing

### *Symbol* CRCToSymbol(*string*)
- *string*: 1st Parameter
- Returns a *Symbol* object (which is a lua string)

### *void* CriticalError(*string*)
- *string*: 1st Parameter
- No returned value

### *void* ControllerPlay(*PlaybackController*)
- *PlaybackController*: 1st Parameter
- No returned value
- This function does nothing if the PlaybackController is nil.

### *void* ControllerPause(*PlaybackController*)
- *PlaybackController*: 1st Parameter
- No returned value
- This function does nothing if the PlaybackController is nil.

### *void* ControllerStop(*PlaybackController*)
- *PlaybackController*: 1st Parameter
- No returned value
- This function does nothing if the PlaybackController is nil.

### *void* ControllerWait(*PlaybackController*)
- *PlaybackController*: 1st Parameter
- No returned value

### *void* ControllerFadeIn(*PlaybackController*, *number*, *boolean*)
- *PlaybackController*: 1st Parameter
- *number*: 2nd Parameter, Float Value
- *boolean*: 3rd Parameter ***(optional)***
- No returned value
- This function does nothing if the PlaybackController is nil.

### *void* ControllerFadeOut(*PlaybackController*, *number*, *boolean*)
- *PlaybackController*: 1st Parameter
- *number*: 2nd Parameter, Float Value
- *boolean*: 3rd Parameter ***(optional)***
- No returned value
- This function does nothing if the PlaybackController is nil.

### *void* ControllerFadeTo(*PlaybackController*, *number*, *number*, *boolean*)
- *PlaybackController*: 1st Parameter
- *number*: 2nd Parameter, Float Value
- *number*: 3rd Parameter, Float Value
- *boolean*: 4th Parameter ***(optional)***
- No returned value
- This function does nothing if the PlaybackController is nil.

### *void* ControllerSetTimeScale(*PlaybackController*, *number*)
- *PlaybackController*: 1st Parameter
- *number*: 2nd Parameter, Float Value
- No returned value

### *number* ControllerGetTimeScale(*PlaybackController*)
- *PlaybackController*: 1st Parameter
- Returns a number, Float Value

### *void* ControllerKill(*PlaybackController*)
- *PlaybackController*: 1st Parameter
- No returned value
- This function does nothing if the PlaybackController is nil.

### *number* ControllerGetLength(*PlaybackController*)
- *PlaybackController*: 1st Parameter
- Returns a number, if PlaybackController is nil then this function returns nil.

### *void* ControllerSetLength(*PlaybackController*, *number*)
- *PlaybackController*: 1st Parameter
- *number*: 2nd Parameter, Float Value
- No returned value
- This function does nothing if the PlaybackController is nil.

### *boolean* ControllerIsPlaying(*PlaybackController*)
- *PlaybackController*: 1st Parameter
- Returns a boolean

### *boolean* ControllerIsPaused(*PlaybackController*)
- *PlaybackController*: 1st Parameter
- Returns a boolean

### *void* ControllerSetVolume(*PlaybackController*, *number*)
- *PlaybackController*: 1st Parameter
- *number*: 2nd Parameter
- No returned value
- This function does nothing if the PlaybackController is nil.

### *void* ControllerSetSoundVolume(*PlaybackController*, *number*)
- *PlaybackController*: 1st Parameter
- *number*: 2nd Parameter
- No returned value
- This function does nothing if the PlaybackController is nil.

### *void* ControllerSetLooping(*PlaybackController*, *boolean*)
- *PlaybackController*: 1st Parameter
- *boolean*: 2nd Parameter
- No returned value
- This function does nothing if the PlaybackController is nil.

### *void* ControllerSetMirrored(*PlaybackController*, *boolean*)
- *PlaybackController*: 1st Parameter
- *boolean*: 2nd Parameter
- No returned value
- This function does nothing if the PlaybackController is nil.

### *void* ControllerSetEndPause(*PlaybackController*, *boolean*)
- *PlaybackController*: 1st Parameter
- *boolean*: 2nd Parameter
- No returned value
- This function does nothing if the PlaybackController is nil.

### *void* ControllerSetBeginPause(*PlaybackController*, *boolean*)
- *PlaybackController*: 1st Parameter
- *boolean*: 2nd Parameter
- No returned value
- This function does nothing if the PlaybackController is nil.

### *number* ControllerGetTime(*PlaybackController*)
- *PlaybackController*: 1st Parameter
- Returns a number, will return 0.0 if PlaybackController is nil.

### *void* ControllerSetTime(*PlaybackController*, *number*)
- *PlaybackController*: 1st Parameter
- *number*: 2nd Parameter
- No returned value
- This function does nothing if the PlaybackController is nil.

### *void* ControllerSetTimePercent(*PlaybackController*, *number*)
- *PlaybackController*: 1st Parameter
- *number*: 2nd Parameter
- No returned value
- This function does nothing if the PlaybackController is nil.

### *number* ControllerGetContribution(*PlaybackController*)
- *PlaybackController*: 1st Parameter
- Returns a number, will return 0.0 if PlaybackController is nil.

### *void* ControllerSetContribution(*PlaybackController*, *number*)
- *PlaybackController*: 1st Parameter
- *number*: 2nd Parameter
- No returned value
- This function does nothing if the PlaybackController is nil.

### *void* ControllerDisableTimeSync(*PlaybackController*, *boolean*)
- *PlaybackController*: 1st Parameter
- *boolean*: 2nd Parameter
- No returned value
- This function does nothing if the PlaybackController is nil.

### *void* ControllerSetVoice(*PlaybackController*, *boolean*)
- *PlaybackController*: 1st Parameter
- *boolean*: 2nd Parameter
- No returned value
- This function does nothing if the PlaybackController is nil.

### *void* ControllerSetMusic(*PlaybackController*, *boolean*)
- *PlaybackController*: 1st Parameter
- *boolean*: 2nd Parameter
- No returned value
- This function does nothing if the PlaybackController is nil.

### *void* ControllerSetAmbient(*PlaybackController*, *boolean*)
- *PlaybackController*: 1st Parameter
- *boolean*: 2nd Parameter
- No returned value
- This function does nothing if the PlaybackController is nil.

### *void* ControllerSetLanguage(*PlaybackController*, *boolean*)
- *PlaybackController*: 1st Parameter
- *boolean*: 2nd Parameter
- No returned value
- This function does nothing if the PlaybackController is nil.

### *void* ControllerSetName(*PlaybackController*, *string*)
- *PlaybackController*: 1st Parameter
- *string*: 2nd Parameter
- No returned value
- This function does nothing if the PlaybackController is nil.

### *PlaybackController* ControllerFind(*string*)
- *string*: 1st Parameter
- Returns a PlaybackController, if one can't be found then it will return nil.

### *void* ControllerDrift(*PlaybackController*, *boolean*)
- *PlaybackController*: 1st Parameter
- *boolean*: 2nd Parameter
- No returned value
- This function does nothing if the PlaybackController is nil.

### *void* ControllerSetPriority(*PlaybackController*, *number*)
- *PlaybackController*: 1st Parameter
- *number*: 2nd Parameter, this expects a signed integer number
- No returned value
- This function does nothing if the PlaybackController is nil.

### *number* ControllerGetPriority(*PlaybackController*)
- *PlaybackController*: 1st Parameter
- Returns a number, if PlaybackController is nil it will return nil.

### *void* ControllerSetScene(*PlaybackController*, *SceneObject*)
- *PlaybackController*: 1st Parameter
- No returned value
- This function does nothing if the PlaybackController is nil.

### *Chore* ControllerGetChore(*PlaybackController*)
- *PlaybackController*: 1st Parameter
- Returns a Chore, if there is no Chore or PlaybackController it will return nil.

### *PlaybackController* ControllerGetParent(*PlaybackController*, *boolean*)
- *PlaybackController*: 1st Parameter
- *boolean*: 2nd Parameter ***(optional)***
- Returns a PlaybackController, if there is no PlaybackController it will return nil, if there is no parent PlayerController found it will return nil.

### *boolean* Create(*string*)
- *string*: 1st Parameter
- Returns a boolean

### *void* CacheSaveGameImage()
- No returned value
- This function does nothing

### *void* CameraActivate(*AgentObject*)
- *AgentObject*: 1st Parameter
- No returned value

### *Vector3* CameraGetScreenPosFromWorldPos(*AgentObject*, *Vector3*)
- *AgentObject*: 1st Parameter
- *Vector3*: 2nd Parameter
- Returns a Vector3, will return nil if there is no AgentObject

### *void* CameraPush(*AgentObject*)
- *AgentObject*: 1st Parameter
- No returned value
- This function does nothing if there is no Camera on AgentObject.

### *void* CameraPop(*AgentObject*)
- *AgentObject*: 1st Parameter
- No returned value
- This function does nothing if there is no Camera on AgentObject.

### *void* CameraSettle(*AgentObject*, *boolean*)
- *AgentObject*: 1st Parameter
- *boolean*: 2nd Parameter
- No returned value
- This function does nothing if AgentObject is nil, or if there is no NavCam on AgentObject.

### *number* CameraGetFOV(*AgentObject*)
- Returns a number
- *AgentObject*: 1st Parameter

### *void* CameraSetFOV(*AgentObject*, *number*)
- *AgentObject*: 1st Parameter
- *number*: 2nd Parameter
- No returned value

### *void* CameraSetNavTarget(*AgentObject*, *AgentObject*)
- *AgentObject*: 1st Parameter
- *AgentObject*: 2nd Parameter
- No returned value

### *void* CameraSetNavTargetOffset(*AgentObject*, *number*, *number*, *number*)
- *AgentObject*: 1st Parameter
- *number*: 2nd Parameter
- *number*: 3rd Parameter
- *number*: 4th Parameter
- No returned value

### *void* CameraSetNavHome(*AgentObject*, *number*, *number*, *number*)
- *AgentObject*: 1st Parameter
- *number*: 2nd Parameter
- *number*: 3rd Parameter
- *number*: 4th Parameter
- No returned value

### *void* CameraSetNavMode(*AgentObject*, *string*)
- *AgentObject*: 1st Parameter
- *string*: 2nd Parameter
- No returned value

### *void* CameraSetNavResetOnActivate(*AgentObject*, *boolean*)
- *AgentObject*: 1st Parameter
- *boolean*: 2nd Parameter
- No returned value

### *void* CameraSetNavChore(*AgentObject*, *Chore*)
- *AgentObject*: 1st Parameter
- *Chore*: 2nd Parameter
- No returned value

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
- No returned value

### *void* CameraBlendPush(*AgentObject*, *number*, *number*, *number*)
- *AgentObject*: 1st Parameter
- *number*: 2nd Parameter
- *number*: 3rd Parameter
- *number*: 4th Parameter
- No returned value

### *void* CameraBlendPop(*AgentObject*, *number*, *number*, *number*)
- *AgentObject*: 1st Parameter
- *number*: 2nd Parameter
- *number*: 3rd Parameter
- *number*: 4th Parameter
- No returned value

### *PlaybackController* ChorePlay(*Chore*, *number*)
- *Chore*: 1st Parameter
- *number*: 2nd Parameter
- Returns a PlaybackController

### *void* ChoreSetAgentRemap(*string*, *string*)
- *string*: 1st Parameter
- *string*: 2nd Parameter
- No returned value

### *void* ChorePlayAndWait(*Chore*, *number*, *number*, *number*)
- *Chore*: 1st Parameter
- *number*: 2nd Parameter
- *number*: 3rd Parameter
- *number*: 4th Parameter
- No returned value

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
- No returned value

### *void* ChoreSetAttachmentPosition(*Chore*, *string*, *number*, *number*, *number*)
- *Chore*: 1st Parameter
- *string*: 2nd Parameter
- *number*: 3rd Parameter
- *number*: 4th Parameter
- *number*: 5th Parameter
- No returned value

### *void* ChoreSetAttachmentRotation(*Chore*, *string*, *number*, *number*, *number*)
- *Chore*: 1st Parameter
- *string*: 2nd Parameter
- *number*: 3rd Parameter
- *number*: 4th Parameter
- *number*: 5th Parameter
- No returned value

### *void* ChoreSetAttachmentQuaternion(*Chore*, *string*, *number*, *number*, *number*, *number*)
- *Chore*: 1st Parameter
- *string*: 2nd Parameter
- *number*: 3rd Parameter
- *number*: 4th Parameter
- *number*: 5th Parameter
- No returned value

### *void* ChoreSetAttachmentPreserveWorldPos(*Chore*, *string*, *boolean*)
- *Chore*: 1st Parameter
- *string*: 2nd Parameter
- *boolean*: 3rd Parameter
- No returned value

### *void* ChoreSetAttachmentLeaveAttached(*Chore*, *string*, *boolean*)
- *Chore*: 1st Parameter
- *string*: 2nd Parameter
- *boolean*: 3rd Parameter
- No returned value

### *void* ChoreAddAttachmentKey(*Chore*, *string*, *number*, *string*, *string*, *Symbol*, *boolean*, *Vector3*, *Quaternion*)
- *Chore*: 1st Parameter
- *string*: 2nd Parameter
- *number*: 3rd Parameter
- *string*: 4th Parameter
- *string*: 5th Parameter 
- *boolean*: 7th Parameter ***(optional)***
- *Vector3*: 8th Parameter ***(optional)***
- *Quaternion*: 9th Parameter ***(optional)***
- No returned value

### *void* ChoreResourceRemoveAnimatedValue(*Chore*, *number*, *string*)
- *Chore*: 1st Parameter
- *number*: 2nd Parameter
- *string*: 3rd Parameter
- No returned value

### *void* ChoreAgentEnableRandomSFX(*Chore*, *AgentObject*)
- *Chore*: 1st Parameter
- *AgentObject*: 2nd Parameter
- No returned value

### *void* ChoreForceLookAtConstraint(*AgentObject*, *string*, *string*, *number*)
- *AgentObject*: 1st Parameter
- *string*: 2nd Parameter
- *string*: 3rd Parameter
- *number*: 4th Parameter
- No returned value

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

<!-- ### ChoreGetBaseChore() -->

<!-- ### ChoreGetMasterCut() -->

<!-- ### ChoreGetCut() -->

<!-- ### ChoreGoToPauseAndKill() -->

### *void* ChoreRegenerateStyleIdleTransition(*string*)
- *string*: 1st Parameter
- No returned value

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
- No returned value

<!-- ### ContainerInsertElement() -->

<!-- ### ContainerRemoveElement() -->

<!-- ### ContainerSetElement() -->

### *void* CursorEnableMultiple(*boolean*, *number*)
- *boolean*: 1st Parameter
- *number*: 2nd Parameter ***(optional)***
- No returned value

### *void* CursorSet(*PropertySet*, *number*)
- *PropertySet*: 1st Parameter
- *number*: 2nd Parameter ***(optional)***
- No returned value

### *void* CursorReset(*number*)
- *number*: 1st Parameter ***(optional)***
- No returned value

<!-- ### CursorConfine() -->

### *Vector3* CursorGetPos(*number*)
- *number*: 1st Parameter ***(optional)***
- Returns a Vector3

### *Vector3* CursorGetDevicePos(*number*)
- *number*: 1st Parameter ***(optional)***
- Returns a Vector3

### *void* CursorSetAtScreenCenter(*number*)
- *number*: 1st Parameter ***(optional)***
- No returned value

### *void* CursorSetPos(*Vector2*, *number*)
- *Vector2*: 1st Parameter
- *number*: 2nd Parameter ***(optional)***
- No returned value

### *void* CursorHide(*boolean*, *number*)
- *boolean*: 1st Parameter
- *number*: 2nd Parameter ***(optional)***
- No returned value

### *boolean* CursorHidden(*number*)
- *number*: 1st Parameter ***(optional)***
- Returns a boolean

### *void* CursorEnable(*boolean*, *number*)
- *boolean*: 1st Parameter
- *number*: 2nd Parameter ***(optional)***
- No returned value

### *boolean* CursorIsEnabled(*number*)
- *number*: 1st Parameter ***(optional)***
- Returns a boolean

### *void* CursorSetTexture(*T3Texture*, *number*)
- *T3Texture*: 1st Parameter
- *number*: 2nd Parameter ***(optional)***
- No returned value

### *void* CursorSetOffset(*number*, *number*, *number*)
- *number*: 1st Parameter
- *number*: 2nd Parameter
- *number*: 3rd Parameter ***(optional)***
- No returned value

### *T3Texture* CursorGetTexture(*number*)
- *number*: 1st Parameter ***(optional)***
- Returns a T3Texture

### *void* CursorSetSize(*number*, *number*)
- *number*: 1st Parameter
- *number*: 2nd Parameter ***(optional)***
- No returned value

### *void* CursorSetColor(*number*, *number*, *number*, *number*, *number*)
- *number*: 1st Parameter
- *number*: 2nd Parameter
- *number*: 3rd Parameter
- *number*: 4th Parameter
- *number*: 5th Parameter ***(optional)***
- No returned value

### *Vector3* CursorGet3DOrigin(*SceneObject*)
- Returns a Vector3 ***(optional)***

### *Vector3* CursorGet3DDirection(*SceneObject*)
- Returns a Vector3 ***(optional)***

### *AgentObject* CursorGetAgent(*number*)
- *number*: 1st Parameter ***(optional)***
- Returns an AgentObject

### *Vector3* CursorGetPointOnAgent(*AgentObject*)
- *AgentObject*: 1st Parameter 
- Returns a Vector3

### *void* CursorEnableRelativeMode(*boolean*)
- *boolean*: 1st Parameter
- No returned value
- This function does nothing

### *void* CreateEventLogEvent(*string*, *number*, *boolean*)
- *string*: 1st Parameter
- *number*: 2nd Parameter
- *boolean*: 3rd Parameter ***(optional)***
- No returned value

<!-- ### CreateSessionEventLog() -->

# C

### *string* DownloadDocumentRetrieve(*string*)
- *string*: 1st Parameter
- Returns a string

<!-- ### DownloadDocumentsFromServer() -->

### *void* DisableEpisode()
- No returned value
- This function does nothing

### *void* DbgToggleInputTester()
- No returned value

### *void* DbgSetAssertLevel()
- No returned value
- This function does nothing

### *void* DbgSetFakeSlowIOFactors()
- No returned value
- This function does nothing

### *void* DbgSetFixedTimeStep(*number*)
- No returned value
- This function does nothing

### *void* DbgSetMinFrameTime(*number*)
- No returned value
- This function does nothing

### *void* DeveloperKeyPressed()
- Returns a boolean

### *string* DoString(*string*)
- Returns a boolean

### *Vector3* DeviceToViewport(*Vector2*)

### *void* DoLoad(*string*)

### *void* DbgStat(*string*, *boolean*)

### *void* DbgTracePropChanges()

### *void* DbgListCloudData()

### *void* DbgPlatformForceGPUQuality()

### *void* DbgListSaveData()

### *void* DbgSceneDumpLightInfo()

### *void* DbgListShaders(*string*)

### *void* DebugPrintLuaMemoryStats()

### *void* DisableStats()

### *number* DialogRun(*DialogResource*, *string*)

### *void* DialogRunAndWait(*DialogResource*, *string*, *string*)

### *boolean* DialogContinue(*number*, *string*, *string*)

### *void* DialogContinueAndWait(*number*, *string*, *string*)

### *void* DialogWait(*number*)

### *boolean* DialogStop(*number*)

### *void* DialogStopAll()

### *boolean* DialogExists(*DialogResource*, *string*, *boolean*)

### *void* DialogSetBranch(*number*, *string*, *string*)

### *boolean* DialogJumpToBranch(*DialogResource*, *string*)

### *void* DialogGetSoloItemNotes()

### *void* DialogUISetNewChoiceCallback(*string*)

### *void* DialogUISetDlgBeginCallback(*string*)

### *void* DialogUISetDlgEndCallback(*string*)

### *void* DialogUISetBranchBeginCallback(*string*)

### *void* DialogUISetBranchEndCallback(*string*)

### *void* DialogUISetItemBeginCallback(*string*)

### *void* DialogUISetItemEndCallback(*string*)

### *void* DialogUISetExchangeBeginCallback(*string*)

### *void* DialogUISetExchangeEndCallback(*string*)

### *void* DialogUISetDlgTestCallback(*string*)

### *boolean* DialogSelectChoice(*number*, *number*)

### *number* DialogGetNumChoices(*number*)

### *string* DialogGetChoiceDispText(*number*, *number*)

### *string* DialogGetChoiceFirstLine(*number*, *number*)

### *string* DialogGetChoiceName(*number*, *number*)

### *ScriptObject* DialogGetChoiceUserdata(*number*, *number*)

### *ScriptObject* DialogGetSoloItemUserdata(*DialogResource*, *string*)

### *ScriptObject[]* DialogGetChoiceTexture(*number*, *number*)

### *boolean* DialogIsRunning(*number*)

### *number* DialogGetCurrentID(*number*)

### *boolean* DialogLineIsRunning()

### *PlaybackController* DialogGetCurPlaybackController(*number*)

### *PlaybackController* DialogGetPlaybackController(*number*)

### *string* DialogGetInstanceActiveDlgName(*number*)

### *boolean* DialogIsSoloItemRunning(*number*)

### *boolean* DialogIsSoloItemCutscene(*number*)

### *SceneObject* DialogGetSoloItemChore(*number*)

### *string* DialogGetText(*DialogResource*, *string*)

### *void* DialogClearRuntimeState()

### *void* DialogAdvanceCurrentLine(*number*)

### *void* DialogSanityCheck()

<!-- ### DialogSetChoreAgentRemap() -->

### *void* DialogSetBCItemExecuteBehavior()

### *void* DialogSetBCEnterItemBehavior()

### *void* DialogSetBGChoreBehaviorVersion2()

### *void* DialogSetAllowDispTextForEmptyExchangesBehavior()

### *void* DialogSetExchangeRepeatedCallback(*string*)

### *number* DialogGetSoloItemNumExchanges(*DialogResource*, *string*)

### *string[]* DialogGetAllNames(*DialogResource*, *string*)

### *number* DialogExchangeGetNumLines(*DialogResource*, *number*)

### *SceneObject* DialogExchangeGetChore(*DialogResource*, *number*)

<!-- ### DialogGetMissingChores() -->

### *void* DialogSetBranchBackgroundChore(*DialogResource*, *string*, *string*)

### *void* DialogSetDialogBackgroundChore(*DialogResource*, *string*, *Chore*)

### *boolean* DialogItemExitsDialog(*number*)

### *boolean* DialogExchangeExitsDialog(*number*)

### *void* DlgSetBehaviorAllowEndlessLangAliasChain()

### *void* DlgEnable20System()

### *boolean* DlgIs20SystemEnabled()

### *void* DlgAddCallbackChoicesAvailable(*string*)

### *void* DlgAddCallbackChoicesChanged(*string*)

### *void* DlgAddCallbackDialogBegin(*string*)

### *void* DlgAddCallbackDialogEnd(*string*)

### *void* DlgSetCallbackNodeBegin(*string*, *string*)

### *void* DlgSetCallbackNodeEnd(*string*, *string*)

### *void* DlgClearNodeCallbacks()

### *number* DlgRun(*Dlg*, *DlgObjID*)

### *void* DlgRunAndWait(*Dlg*, *DlgObjID*)

### *void* DlgWait(*number*)

### *PlaybackController* DlgGetCurPlaybackController(*number*)

### *boolean* DlgIsRunning(*number*)

### *void* DlgStop(*number*, *boolean*)

### *void* DlgStopAfterNodeCompletes(*number*, *boolean*)

### *void* DlgPause(*number*)

### *void* DlgResume(*number*)

### *void* DlgClearRuntimeState()

### *void* DlgSetTrace()

### *void* DlgGetUserTable(*number*)

<!-- ### DlgGetChoices() -->

### *void* DlgSelectChoice(*number*, *number*)

### *void* DlgPreSelectChoice(*number*, *number*)

### *SceneObject* DlgGetCurrentDialog(*number*)

### *DlgObjID* DlgGetCurrentNode(*number*)

### *boolean* DlgChoiceLeadsToUnplayedNode(*string*, *number*, *number*, *number*)

### *DlgNode* DlgFindNode(*Dlg*, *DlgObjID*)

### *DlgNode* DlgNodeGetNextNode(*Dlg*, *DlgObjID*)

### *DlgNode* DlgNodeGetPrevNode(*Dlg*, *DlgObjID*)

### *DlgNode* DlgNodeGetParentNode(*Dlg*, *DlgObjID*)

### *DlgNode[]* DlgNodeGetChildNodes(*Dlg*, *DlgObjID*, *boolean*)

### *DlgNode* DlgNodeGetJumpTarget(*Dlg*, *DlgObjID*)

### *boolean* DlgObjectLeadsToUnplayedNode(*string*, *Dlg*, *DlgObjID*, *number*)

<!-- ### DlgEvaluateToNode() -->

<!-- ### DlgEvaluateToNodeMultiType() -->

<!-- ### DlgEvaluateGetNextChore() -->

<!-- ### DlgCollectNodesOfType() -->

### *nil* DlgCollectAllNodesInChain()

### *Symbol[]* DlgGetChainHeadNodes(*Dlg*, *Symbol*)

### *Symbol[]* DlgGetFolderNames(*Dlg*)

### *string* DlgGetNodeName(*Dlg*, *DlgObjID*)

### *boolean* DlgIsObjVisible(*Dlg*, *DlgObjID*)

<!-- ### DlgGetObjUserPropsValue() -->

### *boolean* DlgSetObjUserPropsValue()

### *boolean* DlgUserPropIsLocal(*Dlg*, *DlgObjID*, *Symbol*)

<!-- ### DlgObjectPropsGetUserProps() -->

### *nil* DlgObjectPropsGetToolProps(*number*, *number*, *boolean*)

### *nil* DlgObjectPropsGetProductionProps(*number*, *number*, *boolean*)

### *string* DlgGetTextNodeText(*Dlg*, *DlgObjID*)

### *Rule* DlgNodeLogicGetRule(*Dlg*, *DlgObjID*)

### *string* DlgExchangeGetChore(*Dlg*, *DlgObjID*)

<!-- ### DlgGetExchangeNodeText() -->

<!-- ### DlgGetExchangeNodeTextIDs() -->

<!-- ### DlgGetExchangeNodeSpeakers() -->

<!-- ### DlgGetExchangeNodeSpeakerNames() -->

<!-- ### DlgSetExchangeChoreAgentRemap() -->

### *void* DlgClearExchangeChoreAgentRemap()

<!-- ### DlgChoicesGetDisplayProps() -->

### *string* DlgGetJumpBehavior(*Dlg*, *DlgObjID*)

### *number* DlgStartGetOutputIndex(*Dlg*, *DlgObjID*)

### *void* DlgSetScriptNodeBlockingDefault(*boolean*)

### *nil* DlgAddNode()

### *boolean* DlgSetJumpData(*Dlg*, *DlgObjID*, *boolean*, *boolean*)

### *boolean* DlgSetChore(*Dlg*, *DlgObjID*, *string*)

<!-- ### DlgGetVisibilityConditions() -->

### *boolean* DlgSetBoolRuleCondition(*Dlg*, *DlgObjID*, *string*, *string*, *boolean*)

### *boolean* DlgNodeSetScriptRuleVisibility(*Dlg*, *DlgObjID*, *string*)

### *boolean* DlgNodeSetIntRuleVisibility(*Dlg*, *DlgObjID*, *string*, *string*, *number*)

### *boolean* DlgNodeSetFloatRuleVisibility(*Dlg*, *DlgObjID*, *string*, *string*, *number*)

### *boolean* DlgSetNodeName(*Dlg*, *DlgObjID*, *string*)

### *boolean* DlgSetScriptText(*Dlg*, *DlgObjID*, *string*)

### *boolean* DlgAddExchangeText(*Dlg*, *DlgObjID*, *string*, *string*)

### *nil* DlgGetTimeCondition(*Dlg*, *DlgObjID*)

### *boolean* DlgSetTimeCondition(*Dlg*, *DlgObjID*, *number*)

<!-- ### DlgGetSequenceNodeData() -->

### *boolean* DlgSetSequenceNodeData(*Dlg*, *DlgObjID*, *string*, *string*)

### *boolean* DlgSetSequenceNodeConditionalData(*Dlg*, *DlgObjID*, *string*, *string*)

### *boolean* DlgResetSequenceNodeElements(*number*)

### *boolean* DlgSetConditionNodeConditionalData(*Dlg*, *DlgObjID*, *string*, *string*)

### *boolean* DlgForceSequenceNodeConditional(*Dlg*, *DlgObjID*, *boolean*)

### *boolean* DlgResetConditionNodeElements(*number*)

### *boolean* DlgSetNodeIdle()

### *nil* DlgInsertNode(*Dlg*, *DlgObjID*, *string*)

### *nil* DlgTextNodeSetText(*Dlg*, *DlgObjID*, *string*)

<!-- ### DlgFindAliases() -->

### *nil* DlgGetActorAgentNames()

### *void* DlgPreloadAll(*Dlg*, *boolean*)

### *void* DlgPreload(*Dlg*, *DlgObjID*, *number*, *number*, *number*, *boolean*, *boolean*)

### *void* DeleteEventsInRange(*EventStorage*, *number*, *number*)

### *void* DeleteAllEventsAfterEvent(*EventStorage*, *Symbol*, *number*, *boolean*)

# E



More to be added...