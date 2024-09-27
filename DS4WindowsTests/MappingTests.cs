﻿using System.Xml.Serialization;
using DS4Windows;
using DS4WinWPF.DS4Control.DTOXml;

namespace DS4WindowsTests
{
    //[TestClass]
    public class MappingTests
    {
        private string testProfileXml = string.Empty;

        public MappingTests()
        {
            #region ProfileXml
            testProfileXml = @"<?xml version=""1.0"" encoding=""utf-8""?>
<!-- DS4Windows Configuration Data. 12/08/2023 14:26:24 -->
<!-- Made with DS4Windows version 3.2.21 -->

<DS4Windows app_version=""3.2.21"" config_version=""5"">
  <touchToggle>True</touchToggle>
  <idleDisconnectTimeout>0</idleDisconnectTimeout>
  <outputDataToDS4>True</outputDataToDS4>
  <Color>0,0,255</Color>
  <RumbleBoost>100</RumbleBoost>
  <RumbleAutostopTime>0</RumbleAutostopTime>
  <LightbarMode>DS4Win</LightbarMode>
  <ledAsBatteryIndicator>False</ledAsBatteryIndicator>
  <FlashType>0</FlashType>
  <flashBatteryAt>0</flashBatteryAt>
  <touchSensitivity>100</touchSensitivity>
  <LowColor>0,0,0</LowColor>
  <ChargingColor>0,0,0</ChargingColor>
  <FlashColor>0,0,0</FlashColor>
  <touchpadJitterCompensation>True</touchpadJitterCompensation>
  <lowerRCOn>False</lowerRCOn>
  <tapSensitivity>0</tapSensitivity>
  <doubleTap>False</doubleTap>
  <scrollSensitivity>0</scrollSensitivity>
  <LeftTriggerMiddle>0</LeftTriggerMiddle>
  <RightTriggerMiddle>0</RightTriggerMiddle>
  <TouchpadInvert>0</TouchpadInvert>
  <TouchpadClickPassthru>False</TouchpadClickPassthru>
  <L2AntiDeadZone>0</L2AntiDeadZone>
  <R2AntiDeadZone>0</R2AntiDeadZone>
  <L2MaxZone>100</L2MaxZone>
  <R2MaxZone>100</R2MaxZone>
  <L2MaxOutput>100</L2MaxOutput>
  <R2MaxOutput>100</R2MaxOutput>
  <ButtonMouseSensitivity>25</ButtonMouseSensitivity>
  <ButtonMouseOffset>0.008</ButtonMouseOffset>
  <Rainbow>0</Rainbow>
  <MaxSatRainbow>100</MaxSatRainbow>
  <LSDeadZone>10</LSDeadZone>
  <RSDeadZone>10</RSDeadZone>
  <LSAntiDeadZone>20</LSAntiDeadZone>
  <RSAntiDeadZone>20</RSAntiDeadZone>
  <LSMaxZone>100</LSMaxZone>
  <RSMaxZone>100</RSMaxZone>
  <LSVerticalScale>100</LSVerticalScale>
  <RSVerticalScale>100</RSVerticalScale>
  <LSMaxOutput>100</LSMaxOutput>
  <RSMaxOutput>100</RSMaxOutput>
  <LSMaxOutputForce>False</LSMaxOutputForce>
  <RSMaxOutputForce>False</RSMaxOutputForce>
  <LSDeadZoneType>Radial</LSDeadZoneType>
  <RSDeadZoneType>Radial</RSDeadZoneType>
  <LSAxialDeadOptions>
    <DeadZoneX>10</DeadZoneX>
    <DeadZoneY>10</DeadZoneY>
    <MaxZoneX>100</MaxZoneX>
    <MaxZoneY>100</MaxZoneY>
    <AntiDeadZoneX>20</AntiDeadZoneX>
    <AntiDeadZoneY>20</AntiDeadZoneY>
    <MaxOutputX>100</MaxOutputX>
    <MaxOutputY>100</MaxOutputY>
  </LSAxialDeadOptions>
  <RSAxialDeadOptions>
    <DeadZoneX>10</DeadZoneX>
    <DeadZoneY>10</DeadZoneY>
    <MaxZoneX>100</MaxZoneX>
    <MaxZoneY>100</MaxZoneY>
    <AntiDeadZoneX>20</AntiDeadZoneX>
    <AntiDeadZoneY>20</AntiDeadZoneY>
    <MaxOutputX>100</MaxOutputX>
    <MaxOutputY>100</MaxOutputY>
  </RSAxialDeadOptions>
  <LSRotation>0</LSRotation>
  <RSRotation>0</RSRotation>
  <LSFuzz>0</LSFuzz>
  <RSFuzz>0</RSFuzz>
  <LSOuterBindDead>75</LSOuterBindDead>
  <RSOuterBindDead>75</RSOuterBindDead>
  <LSOuterBindInvert>False</LSOuterBindInvert>
  <RSOuterBindInvert>False</RSOuterBindInvert>
  <LSDeltaAccelSettings>
    <Enabled>False</Enabled>
    <Multiplier>4</Multiplier>
    <MaxTravel>0.2</MaxTravel>
    <MinTravel>0.01</MinTravel>
    <EasingDuration>0.2</EasingDuration>
    <MinFactor>1</MinFactor>
  </LSDeltaAccelSettings>
  <RSDeltaAccelSettings>
    <Enabled>False</Enabled>
    <Multiplier>4</Multiplier>
    <MaxTravel>0.2</MaxTravel>
    <MinTravel>0.01</MinTravel>
    <EasingDuration>0.2</EasingDuration>
    <MinFactor>1</MinFactor>
  </RSDeltaAccelSettings>
  <SXDeadZone>0.25</SXDeadZone>
  <SZDeadZone>0.25</SZDeadZone>
  <SXMaxZone>100</SXMaxZone>
  <SZMaxZone>100</SZMaxZone>
  <SXAntiDeadZone>0</SXAntiDeadZone>
  <SZAntiDeadZone>0</SZAntiDeadZone>
  <Sensitivity>1|1|1|1|1|1</Sensitivity>
  <ChargingType>0</ChargingType>
  <MouseAcceleration>False</MouseAcceleration>
  <ButtonMouseVerticalScale>100</ButtonMouseVerticalScale>
  <LaunchProgram />
  <DinputOnly>True</DinputOnly>
  <StartTouchpadOff>False</StartTouchpadOff>
  <TouchpadOutputMode>Mouse</TouchpadOutputMode>
  <SATriggers>-1</SATriggers>
  <SATriggerCond>and</SATriggerCond>
  <SASteeringWheelEmulationAxis>None</SASteeringWheelEmulationAxis>
  <SASteeringWheelEmulationRange>360</SASteeringWheelEmulationRange>
  <SASteeringWheelFuzz>0</SASteeringWheelFuzz>
  <SASteeringWheelSmoothingOptions>
    <SASteeringWheelUseSmoothing>False</SASteeringWheelUseSmoothing>
    <SASteeringWheelSmoothMinCutoff>0.1</SASteeringWheelSmoothMinCutoff>
    <SASteeringWheelSmoothBeta>0.1</SASteeringWheelSmoothBeta>
  </SASteeringWheelSmoothingOptions>
  <TouchDisInvTriggers>-1</TouchDisInvTriggers>
  <GyroSensitivity>100</GyroSensitivity>
  <GyroSensVerticalScale>100</GyroSensVerticalScale>
  <GyroInvert>0</GyroInvert>
  <GyroTriggerTurns>True</GyroTriggerTurns>
  <GyroControlsSettings>
    <Triggers>-1</Triggers>
    <TriggerCond>and</TriggerCond>
    <TriggerTurns>True</TriggerTurns>
    <Toggle>False</Toggle>
  </GyroControlsSettings>
  <GyroMouseSmoothingSettings>
    <UseSmoothing>False</UseSmoothing>
    <SmoothingMethod>none</SmoothingMethod>
    <SmoothingWeight>50</SmoothingWeight>
    <SmoothingMinCutoff>1</SmoothingMinCutoff>
    <SmoothingBeta>0.7</SmoothingBeta>
  </GyroMouseSmoothingSettings>
  <GyroMouseHAxis>0</GyroMouseHAxis>
  <GyroMouseDeadZone>10</GyroMouseDeadZone>
  <GyroMouseMinThreshold>1</GyroMouseMinThreshold>
  <GyroMouseToggle>False</GyroMouseToggle>
  <GyroMouseJitterCompensation>True</GyroMouseJitterCompensation>
  <GyroOutputMode>Controls</GyroOutputMode>
  <GyroMouseStickTriggers>-1</GyroMouseStickTriggers>
  <GyroMouseStickTriggerCond>and</GyroMouseStickTriggerCond>
  <GyroMouseStickTriggerTurns>True</GyroMouseStickTriggerTurns>
  <GyroMouseStickHAxis>0</GyroMouseStickHAxis>
  <GyroMouseStickDeadZone>30</GyroMouseStickDeadZone>
  <GyroMouseStickMaxZone>830</GyroMouseStickMaxZone>
  <GyroMouseStickOutputStick>RightStick</GyroMouseStickOutputStick>
  <GyroMouseStickOutputStickAxes>XY</GyroMouseStickOutputStickAxes>
  <GyroMouseStickAntiDeadX>0.4</GyroMouseStickAntiDeadX>
  <GyroMouseStickAntiDeadY>0.4</GyroMouseStickAntiDeadY>
  <GyroMouseStickInvert>0</GyroMouseStickInvert>
  <GyroMouseStickToggle>False</GyroMouseStickToggle>
  <GyroMouseStickMaxOutput>100</GyroMouseStickMaxOutput>
  <GyroMouseStickMaxOutputEnabled>False</GyroMouseStickMaxOutputEnabled>
  <GyroMouseStickVerticalScale>100</GyroMouseStickVerticalScale>
  <GyroMouseStickJitterCompensation>False</GyroMouseStickJitterCompensation>
  <GyroMouseStickSmoothingSettings>
    <UseSmoothing>False</UseSmoothing>
    <SmoothingMethod>none</SmoothingMethod>
    <SmoothingWeight>50</SmoothingWeight>
    <SmoothingMinCutoff>0.4</SmoothingMinCutoff>
    <SmoothingBeta>0.7</SmoothingBeta>
  </GyroMouseStickSmoothingSettings>
  <GyroSwipeSettings>
    <DeadZoneX>80</DeadZoneX>
    <DeadZoneY>80</DeadZoneY>
    <Triggers>-1</Triggers>
    <TriggerCond>and</TriggerCond>
    <TriggerTurns>True</TriggerTurns>
    <XAxis>Yaw</XAxis>
    <DelayTime>0</DelayTime>
  </GyroSwipeSettings>
  <BTPollRate>4</BTPollRate>
  <LSOutputCurveMode>linear</LSOutputCurveMode>
  <LSOutputCurveCustom />
  <RSOutputCurveMode>linear</RSOutputCurveMode>
  <RSOutputCurveCustom />
  <LSSquareStick>False</LSSquareStick>
  <RSSquareStick>False</RSSquareStick>
  <SquareStickRoundness>5</SquareStickRoundness>
  <SquareRStickRoundness>5</SquareRStickRoundness>
  <LSAntiSnapback>False</LSAntiSnapback>
  <RSAntiSnapback>False</RSAntiSnapback>
  <LSAntiSnapbackDelta>135</LSAntiSnapbackDelta>
  <RSAntiSnapbackDelta>135</RSAntiSnapbackDelta>
  <LSAntiSnapbackTimeout>50</LSAntiSnapbackTimeout>
  <RSAntiSnapbackTimeout>50</RSAntiSnapbackTimeout>
  <LSOutputMode>Controls</LSOutputMode>
  <RSOutputMode>Controls</RSOutputMode>
  <LSOutputSettings>
    <FlickStickSettings>
      <RealWorldCalibration>5.3</RealWorldCalibration>
      <FlickThreshold>0.9</FlickThreshold>
      <FlickTime>0.1</FlickTime>
      <MinAngleThreshold>0</MinAngleThreshold>
    </FlickStickSettings>
  </LSOutputSettings>
  <RSOutputSettings>
    <FlickStickSettings>
      <RealWorldCalibration>5.3</RealWorldCalibration>
      <FlickThreshold>0.9</FlickThreshold>
      <FlickTime>0.1</FlickTime>
      <MinAngleThreshold>0</MinAngleThreshold>
    </FlickStickSettings>
  </RSOutputSettings>
  <DualSenseControllerSettings>
    <RumbleSettings>
      <EmulationMode>Accurate</EmulationMode>
      <EnableGenericRumbleRescale>False</EnableGenericRumbleRescale>
      <HapticPowerLevel>0</HapticPowerLevel>
    </RumbleSettings>
  </DualSenseControllerSettings>
  <L2OutputCurveMode>linear</L2OutputCurveMode>
  <L2OutputCurveCustom />
  <L2TwoStageMode>Disabled</L2TwoStageMode>
  <R2TwoStageMode>Disabled</R2TwoStageMode>
  <L2HipFireTime>100</L2HipFireTime>
  <R2HipFireTime>100</R2HipFireTime>
  <L2TriggerEffect>None</L2TriggerEffect>
  <R2TriggerEffect>None</R2TriggerEffect>
  <R2OutputCurveMode>linear</R2OutputCurveMode>
  <R2OutputCurveCustom />
  <SXOutputCurveMode>linear</SXOutputCurveMode>
  <SXOutputCurveCustom />
  <SZOutputCurveMode>linear</SZOutputCurveMode>
  <SZOutputCurveCustom />
  <TrackballMode>True</TrackballMode>
  <TrackballFriction>10</TrackballFriction>
  <TouchRelMouseRotation>0</TouchRelMouseRotation>
  <TouchRelMouseMinThreshold>1</TouchRelMouseMinThreshold>
  <TouchpadAbsMouseSettings>
    <MaxZoneX>90</MaxZoneX>
    <MaxZoneY>90</MaxZoneY>
    <SnapToCenter>False</SnapToCenter>
  </TouchpadAbsMouseSettings>
  <TouchpadMouseStick>
    <DeadZone>0</DeadZone>
    <MaxZone>8</MaxZone>
    <OutputStick>RightStick</OutputStick>
    <OutputStickAxes>XY</OutputStickAxes>
    <AntiDeadX>0.4</AntiDeadX>
    <AntiDeadY>0.4</AntiDeadY>
    <Invert>0</Invert>
    <MaxOutput>100</MaxOutput>
    <MaxOutputEnabled>False</MaxOutputEnabled>
    <VerticalScale>100</VerticalScale>
    <OutputCurve>Linear</OutputCurve>
    <Rotation>0</Rotation>
    <SmoothingSettings>
      <SmoothingMethod>None</SmoothingMethod>
      <SmoothingMinCutoff>0.8</SmoothingMinCutoff>
      <SmoothingBeta>0.7</SmoothingBeta>
    </SmoothingSettings>
  </TouchpadMouseStick>
  <TouchpadButtonMode>Click</TouchpadButtonMode>
  <AbsMouseRegionSettings>
    <AbsWidth>1</AbsWidth>
    <AbsHeight>1</AbsHeight>
    <AbsXCenter>0.5</AbsXCenter>
    <AbsYCenter>0.5</AbsYCenter>
    <AntiRadius>0</AntiRadius>
    <SnapToCenter>True</SnapToCenter>
  </AbsMouseRegionSettings>
  <OutputContDevice>X360</OutputContDevice>
  <ProfileActions>Disconnect Controller</ProfileActions>
  <Control>
    <Button>
      <Square>Y Button</Square>
      <Triangle>X Button</Triangle>
    </Button>
  </Control>
  <ShiftControl />
</DS4Windows>";
            #endregion
        }

        /// <summary>
        /// Never mind. Mapping is not testable due to hard dependency on the
        /// ControlService class. Does not help Mapping is static.
        /// Too bulky. Don't bother
        /// </summary>
        public void CheckMappingConversion()
        {
            // Test profile reading. Will fail if an XML exception is thrown
            XmlSerializer serializer = new XmlSerializer(typeof(ProfileDTO),
                   ProfileDTO.GetAttributeOverrides());
            using StringReader sr = new StringReader(testProfileXml);
            ProfileDTO dto = serializer.Deserialize(sr) as ProfileDTO;
            dto.DeviceIndex = 8; // Use test slot
            dto.MapTo(Global.store);

            // Test input state to use
            DS4State inputState = new DS4State()
            {
                Square = true,
                LX = 255,
                LY = 128,
                RX = 0,
                RY = 255,
            };

            // Just use reference
            DS4State cState = inputState;

            DS4State outState = new DS4State();
            DS4StateExposed exposedState = new DS4StateExposed(inputState);
            cState = Mapping.SetCurveAndDeadzone(8, cState, outState);

            // Stopping point. Hard dependency on ControlService class
            //Mapping.MapCustom(ind, cState, tempMapState, ExposedState[ind], touchPad[ind], this);
        }
    }
}
