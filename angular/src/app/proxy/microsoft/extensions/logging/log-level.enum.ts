import { mapEnumToOptions } from '@abp/ng.core';

export enum LogLevel {
  Trace = 0,
  Debug = 1,
  Information = 2,
  Warning = 3,
  Error = 4,
  Critical = 5,
  None = 6,
}

export const logLevelOptions = mapEnumToOptions(LogLevel);
