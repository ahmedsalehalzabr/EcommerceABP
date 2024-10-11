import { mapEnumToOptions } from '@abp/ng.core';

export enum Severity {
  Error = 0,
  Warning = 1,
  Info = 2,
}

export const severityOptions = mapEnumToOptions(Severity);
