import { PagedAndSortedResultRequestDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { CategoriesService, CategoryDto } from '@proxy/categories';

@Component({
  selector: 'app-list-categories',
  standalone: true,
  imports: [],
  templateUrl: './list-categories.component.html',
  styleUrl: './list-categories.component.scss'
})
export class ListCategoriesComponent implements OnInit {
categories: CategoryDto[] = [];
input: PagedAndSortedResultRequestDto = {maxResultCount:10, sorting:'', skipCount:0};
constructor(private categoriesService : CategoriesService) {}

  ngOnInit(): void {
   this.categoriesService.getList(this.input).subscribe((response) => {
    this.categories = response.items;
   })
  }

}
