import type { Severity } from '../severity.enum';

export interface ValidationFailure {
  propertyName?: string;
  errorMessage?: string;
  attemptedValue: object;
  customState: object;
  severity: Severity;
  errorCode?: string;
  formattedMessagePlaceholderValues: Record<string, object>;
}

export interface ValidationResult {
  isValid: boolean;
  errors: ValidationFailure[];
  ruleSetsExecuted: string[];
}
