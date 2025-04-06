import { useEffect } from "react";
import { toast as sonnerToast } from "sonner";

export function toast({ title, description, variant = "default", duration = 3000 }) {
    sonnerToast.custom((t) => (
        <div
            className={`w-full max-w-sm rounded-md border p-4 shadow-lg bg-white ${variant === "destructive" ? "border-red-500" : "border-gray-200"
                }`}
        >
            <div className="flex flex-col space-y-1">
                <p className="text-sm font-semibold">{title}</p>
                {description && <p className="text-sm text-muted-foreground">{description}</p>}
            </div>
        </div>
    ), { duration });
}
