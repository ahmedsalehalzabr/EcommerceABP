import { ListService, PagedAndSortedResultRequestDto, PagedResultDto, PermissionService } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { CategoriesService, CategoryDto } from '@proxy/categories';
import { DatatableComponent, NgxDatatableModule } from '@swimlane/ngx-datatable';
import { GetProductListDto, ProductDto, ProductsService } from '@proxy/products';
import { Observable } from 'rxjs';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-list-products',
  standalone: true,
  imports: [ReactiveFormsModule,NgxDatatableModule,CommonModule],
  templateUrl: './list-products.component.html',
  styleUrl: './list-products.component.scss',
  providers: [ListService]
})
export class ListProductsComponent implements OnInit {
products : ProductDto[] = [];
//input: PagedAndSortedResultRequestDto = { maxResultCount: 10, skipCount: 0 };
searchForm: FormGroup;
categories: CategoryDto[] = [];

products$: Observable<PagedResultDto<ProductDto>>;
canCreate: boolean;
  constructor(private productsService: ProductsService,
             private router:Router,
             private formBuilder:FormBuilder,
             private categoriesService: CategoriesService,
             public readonly list:ListService<GetProductListDto>,
             private permissionService: PermissionService
  ) {
    this.buildForm();
  }

  ngOnInit(): void {
    this.categoriesService.getList({maxResultCount:100, skipCount:0}).subscribe((response) => {
      this.categories = response.items;
    });
    this.searchProducts();

    this.canCreate = this.permissionService.getGrantedPolicy('EcommerceApp.Products.CreateEdit');
  }
  buildForm() {
    this.searchForm = this.formBuilder.group({
      filter: new FormControl(''),
      categoryId: new FormControl(null),
      maxResultCount: new FormControl(50, Validators.required),
    });
  }
  addProduct() {
    this.router.navigateByUrl('/products/add');
  }

  searchProducts() {
  // A function that gets query and returns an observable
  const productStreamCreator = query => this.productsService.getList({...query, ...this.searchForm.value});

  this.products$ = this.list.hookToQuery(productStreamCreator); // Subscription is auto-cleared on destroy.  }
}
}
