import { RestService, Rest } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { ValidationResult } from '../fluent-validation/results/models';
import type { AbpValidationException } from '../volo/abp/validation/models';

@Injectable({
  providedIn: 'root',
})
export class BaseService {
  apiName = 'Default';
  

  getValidationExceptionByValidationResult = (validationResult: ValidationResult, config?: Partial<Rest.Config>) =>
    this.restService.request<any, AbpValidationException>({
      method: 'GET',
      url: '/api/app/base/validation-exception',
      params: { isValid: validationResult.isValid, errors: validationResult.errors, ruleSetsExecuted: validationResult.ruleSetsExecuted },
    },
    { apiName: this.apiName,...config });

  constructor(private restService: RestService) {}
}
