//
//  My_Plugin_C.mm
//  My_Plugin_iOS
//
//  Created by eppz! on 18/04/16.
//  Copyright © 2016 eppz!. All rights reserved.
//

#import "UnityString.m"


extern "C"
{
    const char* getMessage()
    { return UnityStringFromNSString(@"Hello Wolrd!"); }
}

