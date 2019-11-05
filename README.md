# K4A Reactive Wall

## Overview

This is a creative research project built by Anna Henson & Lena Wolfe. It uses the unofficial Kinect for Azure BodyTracking plugin kindly developed by Satoshi Maemoto and hosted on GitHub [here](https://github.com/satoshi-maemoto/Azure-Kinect-Unity-Body-Tracker) (MIT Licensed). This readme uses modified installation instructions from Satoshi's plugin because the K4A DLLs cannot be hosted/redistributed on GitHub and must be downloaded separately.

## Requirements

* Unity2019.3.x
* Azure Kinect SDK v1.3.0 
* Azure Kinect Body Tracking SDK v0.9.4

## Required Files

Put following files at "K4A_ReactiveWall\K4AUnityBT". These are available in the installation directories of the Azure Kinect & Body Tracking SDK. 

* dnn_model_2_0.onnx
* onnxruntime.dll
* cublas64_100.dll
* cudart64_100.dll
* cudnn64_7.dll

Put following files at "K4A_ReactiveWall\K4AUnityBT\Assets\K4AUnityBT\Plugins\x86_64".

* depthengine_2_0.dll