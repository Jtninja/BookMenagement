
    export interface BookCategory {
        id: number;
        code: string;
        name: string;
    }

    export class BookCategoryModel implements BookCategory
    {
       public id: number;        
       public code: string;
       public name: string;
    }