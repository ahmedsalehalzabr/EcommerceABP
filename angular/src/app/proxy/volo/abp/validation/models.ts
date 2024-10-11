import type { AbpException } from '../models';
import type { LogLevel } from '../../../microsoft/extensions/logging/log-level.enum';

export interface AbpValidationException extends AbpException {
  validationErrors: any[];
  logLevel: LogLevel;
}
